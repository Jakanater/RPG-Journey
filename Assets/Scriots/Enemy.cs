using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.XPath;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public SetQuestTracjer questTracker;
    public HealthBar healthBar;
    public Quests questScript;
    public ExperiencePoints xp;


    public float maxHealth,health = 10f;
    public bool enemyKilled = false;
    public float xpReward = 10f;
    public float damage = 20f;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        gameObject.tag = "Enemy";
        healthBar.SetMaxValue(maxHealth);
    }

    private void OnCollisionEnter(Collision collision)
    {    
        if(collision.gameObject.tag == "Sword")
        {
            Sword sword = collision.gameObject.GetComponent<Sword>();
            if(sword != null)
            {
                health -= sword.swordDamage;
                healthBar.UpdateValue(health);
                if(health <= 0)
                {
                    xp.ChangeXP(xpReward);
                    enemyKilled = true;
                    gameObject.SetActive(false);
                }
            }
        }
    }
}