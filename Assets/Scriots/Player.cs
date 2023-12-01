using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
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
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Yesssssssss");
            health -= 5;
            healthBar.updateHealth(health);
            UpdateHealthText();
        }
    }

    private void UpdateHealthText()
    {
        healthText.text = health + "/" + maxHealth;
    }
}
