/***
 * Created by: Josh Sutton
 * Date Created: September 22, 2021
 * 
 * Last Edited by:
 * Last Updated: September 22, 2021
 * 
 * Description: Spawns objects.
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    /*** Variables ***/
    public float MaxRadius = 1f;
    public float Interval = 5f;
    public GameObject ObjToSpawn = null;
    private Transform Origin = null;

    void Awake()
    {
        Origin = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0f, Interval);
    }//end Start()

    //Spawns the game object
    void Spawn()
    {
        if(Origin == null)
        {
            return;
        }
        Vector3 SpawnPos = Origin.position + Random.onUnitSphere * MaxRadius;
        SpawnPos = new Vector3(SpawnPos.x, 0f, SpawnPos.z);
        Instantiate(ObjToSpawn, SpawnPos, Quaternion.identity);
    }//end Spawn()
 
}
