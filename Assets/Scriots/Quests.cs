using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;
using UnityEngine.UI;
using UnityEngine.Experimental.Rendering.RenderGraphModule;
using System;
using UnityEditor.MPE;
using System.Linq.Expressions;
public class Quests : MonoBehaviour
{
    public SetQuestTracjer questTracker;
    public Enemy enemy;
    public ExperiencePoints xp;

    public Button questButton;
    public TextMeshProUGUI questButtonText;
    public TextMeshProUGUI questText;
    public TextMeshProUGUI questName;
    public TextMeshProUGUI questDescription;
    public TextMeshProUGUI questReward;

    public float[] xpReward;

    public int currentQuest = 1;
    public int killedQuestEnemies = 0;
    public int killsNeeded = 1;

    public bool isQuestActive = false;
    public bool questCompleted = false;

    public string[] questTitles;
    public string[] questDescriptions;
    public string[] questRewards;

    void Start()
    {
        questText.text = questTitles[0];
    }

    void Update() 
    {
        if(isQuestActive && CheckEnemies() && !questCompleted)
        {
            killedQuestEnemies++;
            Debug.Log(killedQuestEnemies);
            Debug.Log(killsNeeded);
            if(killedQuestEnemies == killsNeeded)
            {
                questCompleted = true;
                Debug.Log(questCompleted);
                questTracker.Completed();
                questTracker.trackerTextSubtext.text = killedQuestEnemies + "/" + killsNeeded + " Enemies Killed";
            }
        }
        CheckQuest();
    }

    public void AddButtonListener()
    {
        if(!questCompleted){
            isQuestActive = true;
            questTracker.SetTrackerText();
        } else {
            isQuestActive = false;
            xp.ChangeXP(xpReward[currentQuest - 1]);
            questTracker.RemoveTrackerText();
            questText.text = "";
            questName.text = "";
            questDescription.text = "";
            questReward.text = "";
            questButtonText.text = "";
        }
    }

    private bool CheckEnemies()
    {
        if(enemy.health <= 0)        
        {
            return true;
        } else {
            return false;
        }
    }

    public void CheckQuest()
    {
        if(questCompleted)
        {
            questName.color = Color.green;
            questDescription.color = Color.green;
            questReward.color = Color.green;
            questButtonText.text = "Completed";
        }
    }
}