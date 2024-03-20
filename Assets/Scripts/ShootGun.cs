using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGun : MonoBehaviour
{
    public KeyCode fireKey = KeyCode.Return;
    public Transform gunTip;
    public float fireRange = 100f;
    public float damageAmount = 10f;

    
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(fireKey))
        {
            RaycastHit hitInfo;
            if(Physics.Raycast(gunTip.position, gunTip.forward, out hitInfo, fireRange))
            {
                GameObject target = hitInfo.collider.gameObject;
                Debug.Log("Hit Target");
                

                //acccess TargetHealth component in target object to deal damage
                TargetHealth targetHealth = target.GetComponent<TargetHealth>();
                if (targetHealth != null)
                {
                    //reference method for taking damage from target component
                    targetHealth.TakeDamage(damageAmount);
                }
            }
            else
            {
                Debug.Log("No Hit");
            }
        }
    }
}
