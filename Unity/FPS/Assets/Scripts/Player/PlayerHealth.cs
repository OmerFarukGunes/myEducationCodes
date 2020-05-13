using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth;
    private int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    public void DeductHealth(int damage)
    {
        currentHealth -= damage;
        if (currentHealth<=0)
        {
            killPlayer();
        }
    }

    private void killPlayer()
    {
        throw new NotImplementedException();
    }

    public void AddHealth(int value)
    {
        
        currentHealth += value;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
