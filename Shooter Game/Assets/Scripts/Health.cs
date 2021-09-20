/***
 * Created by: Josh Sutton
 * Date Created: September 20, 2021
 * 
 * Last Edited by:
 * Last Updated: September 20, 2021
 * 
 * Description: Controls character health
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    /*** Variables***/
    public bool DestroyOnDeath = true;
    public GameObject DeathPatriclesPrefab = null;
    [SerializeField] private float _HealthPoints = 100f;

    public float HealthPoints { 
        get { return _HealthPoints; } 
        set { _HealthPoints = value;
            if (HealthPoints <= 0)
            {
                SendMessage("Die", SendMessageOptions.DontRequireReceiver);
                if (DeathPatriclesPrefab != null)
                {
                    Instantiate(DeathPatriclesPrefab, transform.position, transform.rotation);
                }
                if (DestroyOnDeath)
                {
                    Destroy(gameObject);
                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Health debug
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HealthPoints = 0;
        }//end debug
    }
}
