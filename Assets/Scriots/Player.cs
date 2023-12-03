using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class Player : MonoBehaviour
{
    public Enemy enemy;

    public float health = 100f;
    public float maxHealth = 100f;
    public float baseDamage = 0f;
    public float critMultiplier = 2f;

    public HealthBar healthBar;
    public TextMeshProUGUI healthText;

    void Start()
    {
        health = maxHealth;
        UpdateHealthText();
        healthBar.SetMaxValue(maxHealth);
    }

    void Update()
    {
        /* if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Yesssssssss");
            health -= 5;
            healthBar.UpdateValue(health);
            UpdateHealthText();
        } */
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
        Destroy(this.gameObject);
    }
}