using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;
using UnityEngine.UI;
using UnityEngine.Experimental.Rendering.RenderGraphModule;
public class Quests : MonoBehaviour
{
    public SetQuestTracjer questTracker;

    public Button questButton;
    public TextMeshProUGUI questText;
    public Enemy enemy;

    public int questNumber = 1;
    public int killedQuestEnemies = 0;
    public int killsNeeded = 1;

    public bool isQuestActive = false;
    public bool questCompleted = false;

    void Start()
    {
        questText.text = "Humble Beginnings";
    }

    void Update() {
        if(isQuestActive == true && enemy.health <= 0)
        {
            Debug.Log("active");
            killedQuestEnemies++;
            if(killedQuestEnemies == killsNeeded)
            {
                questTracker.trackerText.color = Color.green;
                questTracker.trackerTextSubtext.color = Color.green;
                questTracker.trackerTextSubtext.text = killedQuestEnemies + "/" + killsNeeded + " Enemies Killed";
            }
        }
    }

    public void AddButtonListener()
    {
        isQuestActive = true;
        questTracker.SetTrackerText();
        Debug.Log("Pressed");
        Debug.Log(isQuestActive);
    }
}