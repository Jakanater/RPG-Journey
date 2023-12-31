using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetQuestTracjer : MonoBehaviour
{
    public TextMeshProUGUI trackerText;
    public TextMeshProUGUI trackerTextSubtext;
    public Quests quests;

    public void SetTrackerText()
    {
        if(quests.currentQuest == 1)
        {
            quests.killsNeeded = 1;
            trackerText.text = "Humble Beginnings";
            trackerTextSubtext.text = quests.killedQuestEnemies + "/" + quests.killsNeeded + " Enemies Killed";
        }
    }

    public void Completed()
    {
        trackerText.color = Color.green;
        trackerTextSubtext.color = Color.green;
    }

    public void RemoveTrackerText()
    {
        trackerText.text = "";
        trackerTextSubtext.text = "";
    }
}
