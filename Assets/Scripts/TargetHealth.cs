using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHealth : MonoBehaviour
{
    public float health = 100f;
    public float currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = health;
    }

    public void TakeDamage(float damaageAmount)
    {
        currentHealth -= damaageAmount;

        if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
