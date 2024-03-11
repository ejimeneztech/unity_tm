using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public GameObject playerVehicle;
    private Vector3 offset = new Vector3(0, 5, -20);
   

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = playerVehicle.transform.position + offset;
    }
}
