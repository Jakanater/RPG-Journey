using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float maxHealth,health = 10f;

    public HealthBar healthBar;

    public Quests questScript;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Enemy";
        healthBar.SetMaxHealth(maxHealth);
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Sword")
        {
            Debug.Log("Collision");
            Sword sword = collision.gameObject.GetComponent<Sword>();
            if(sword != null)
            {
                health -= sword.swordDamage;
                healthBar.updateHealth(health);
                if(health <= 0)
                {
                    Destroy(this.gameObject);
                    if(questScript.isQuestActive == true){
                        questScript.killedQuestEnemies++;
                        questScript.SetTrackerText();
                        if(questScript.killsNeeded == questScript.killedQuestEnemies){
                            questScript.questCompleted = true;
                            questScript.trackerText.color = Color.green;
                            questScript.trackerTextSubtext.color = Color.green;
                        }
                    }
                }
            }
        }
    }
}