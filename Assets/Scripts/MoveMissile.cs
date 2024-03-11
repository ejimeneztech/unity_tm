using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMissile : MonoBehaviour
{
    public float travelSpeed;
 
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * travelSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Destroy"))
        {
            Destroy(collision.gameObject);

            Destroy(gameObject);
        }
    }
}
