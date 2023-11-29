using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public SetQuestTracjer questTracker;

    public float maxHealth,health = 10f;

    public HealthBar healthBar;

    public Quests questScript;

    public bool enemieKilled = false;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        gameObject.tag = "Enemy";
        healthBar.SetMaxHealth(maxHealth);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Sword")
        {
            Sword sword = collision.gameObject.GetComponent<Sword>();
            if(sword != null)
            {
                health -= sword.swordDamage;
                healthBar.updateHealth(health);
                if(health <= 0)
                {
                    Destroy(this.gameObject);
                    enemieKilled = true;
                }
            }
        }
    }
}