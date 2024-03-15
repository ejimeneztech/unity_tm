using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float acceleerateSpeed;
    public float turnSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }


    void move()
    {
        float verticalInput = Input.GetAxis("Vertical");
        if (verticalInput != 0)
        {
            transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime);


            transform.Translate(Vector3.forward * verticalInput * acceleerateSpeed * Time.deltaTime);
        }
    }
}
