using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject bulletPrefab;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBullet();
        }
    }


    void SpawnBullet()
    {
        // Calculate the position in front of the cylinder
        Vector3 spawnPosition = transform.position + transform.forward * 2f; // Adjust the distance as needed

        // Instantiate the sphere at the calculated position with default rotation
        GameObject newBullet = Instantiate( bulletPrefab, spawnPosition, Quaternion.identity);

        // Optionally, you can parent the new sphere to the cylinder if needed
        newBullet.transform.parent = transform.parent; // Parent it to the same parent as the cylinder


    }
}
