/***
 * Created by: Josh Sutton
 * Date Created: September 22, 2021
 * 
 * Last Edited by:
 * Last Updated: September 22, 2021
 * 
 * Description: Ammo script
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    /*** Variables ***/
    public float Damage = 100f;
    public float LifeTime = 2f;

    void OnEnable()
    {
        CancelInvoke();
        Invoke("Die", LifeTime);
    }//end onEnable()

    // Update is called once per frame
    void onTriggerEnter(Collider other)
    {
        Health H = other.gameObject.GetComponent<Health>();

        H.HealthPoints -= Damage;
        Die();
    }

    void Die()
    {
        gameObject.SetActive(false);
    }

}
