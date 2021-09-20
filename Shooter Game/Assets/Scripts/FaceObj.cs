/***
 * Created by: Josh Sutton
 * Date Created: September 20, 2021
 * 
 * Last Edited by:
 * Last Updated: September 20, 2021
 * 
 * Description: 
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceObj : MonoBehaviour
{
    /*** Variables ***/
    public Transform ObjToFace = null;
    public bool FacePlayer = false;

    private void Awake()
    {
        if (!FacePlayer) { return; }
        GameObject PlayerObj = GameObject.FindGameObjectWithTag("Player");

        if(PlayerObj != null)
        {
            ObjToFace = PlayerObj.transform;
        }

    }//end Awake()
    
    // Update is called once per frame
    void Update()
    {
        if (ObjToFace == null) 
        {
            return;
        }
        //Get direction to face object
        Vector3 DirToObject = ObjToFace.position - transform.position;
        if(DirToObject != Vector3.zero)
        {
            transform.localRotation = Quaternion.LookRotation(DirToObject.normalized, Vector3.up);
        }
    }//end Update()
}
