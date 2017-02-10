﻿using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Health : NetworkBehaviour {

    public const int maxHealth = 100;

    
    [SyncVar(hook = "OnChangeHealth")]
    public int currentHealth = maxHealth;


    public RectTransform healthBar;

    public void TakeDamage(int amount)
    {
        if(!isServer)
        {
            return;
        }

        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("Dead!");
        }

    }

    public void OnChangeHealth(int health)
    {
        healthBar.sizeDelta = new Vector2(health, healthBar.sizeDelta.y);

    }
}