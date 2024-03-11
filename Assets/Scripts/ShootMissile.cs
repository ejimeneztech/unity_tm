using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMissile : MonoBehaviour
{
    public GameObject missilePrefab;
    public Transform missileSpawnPoint;
    public KeyCode shootKey = KeyCode.Space;

    void Update()
    {
        if (Input.GetKeyDown(shootKey))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instantiate the missile at the spawn point
        GameObject missile = Instantiate(missilePrefab, missileSpawnPoint.position, missileSpawnPoint.rotation);


        // Ensure that the missile's movement script (MoveMissile) is active
        MoveMissile moveMissileScript = missile.GetComponent<MoveMissile>();
        if (moveMissileScript != null)
        {
            moveMissileScript.enabled = true;
        }
    }
}
