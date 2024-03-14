using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMissile : MonoBehaviour
{
    public float travelSpeed;
    public float damageAmount = 50;
 
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * travelSpeed * Time.deltaTime);
    }


    //change this to deal damage instead of destroy
    void OnCollisionEnter(Collision collision)
    {
        GameObject target = collision.gameObject;
        if(target.CompareTag("Destroy"))
        {
            //acccess TargetHealth component in target object to deal damage
            TargetHealth targetHealth = target.GetComponent<TargetHealth>();
            if (targetHealth != null)
            {
                //reference method for taking damage from target component
                targetHealth.TakeDamage(damageAmount);
            }

            Destroy(gameObject);
        }
    }
}
