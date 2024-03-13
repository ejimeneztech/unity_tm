using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGun : MonoBehaviour
{
    public KeyCode fireKey = KeyCode.Return;
    public Transform gunTip;
    public float fireRange = 100f;
    
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
                Destroy(target);
            }
            else
            {
                Debug.Log("No Hit");
            }
        }
    }
}
