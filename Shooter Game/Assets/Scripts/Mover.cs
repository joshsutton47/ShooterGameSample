/***
 * Created by: Josh Sutton
 * Date Created: September 20, 2021
 * 
 * Last Edited by:
 * Last Updated: September 20, 2021
 * 
 * Description: Enemy Movement
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    /*** Variables ***/
    public float MaxSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * MaxSpeed * Time.deltaTime;    
    }//end Update()
}
