using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class Player : MonoBehaviour
{
    public Enemy enemy;
    public HealthBar healthBar;
    public TextMeshProUGUI healthText;
    public LoadNextScene next;

    public float health = 100f;
    public float maxHealth = 100f;
    public float baseDamage = 0f;
    public float critMultiplier = 2f;
    public float healAmount = 5f;

    void Start()
    {
        health = maxHealth;
        UpdateHealthText();
        healthBar.SetMaxValue(maxHealth);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            health -= 5;
            healthBar.UpdateValue(health);
            UpdateHealthText();
        } else if(Input.GetKeyDown(KeyCode.Backspace))
        {
            health += healAmount;
            healthBar.UpdateValue(health);
            UpdateHealthText();
        }
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Enemy")
        {
            health -= enemy.damage;
            healthBar.UpdateValue(health);
            UpdateHealthText();
            if(health <= 0)
            {
                Die();
            }
            Debug.Log("Collided with Enemy");
        }
    }

    private void UpdateHealthText()
    {
        healthText.text = health + "/" + maxHealth;
    }

    private void Die()
    {
        next.LoadScene();
    }
}