using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;
using UnityEngine.UI;
using UnityEngine.Experimental.Rendering.RenderGraphModule;
public class Quests : MonoBehaviour
{
    public Button questButton;
    public TextMeshProUGUI questText;
    public TextMeshProUGUI trackerText;
    public TextMeshProUGUI trackerTextSubtext;

    public int questNumber = 1;
    public int killedQuestEnemies = 0;
    public int killsNeeded;

    public bool isQuestActive;
    public bool questCompleted = false;

    void Start(){
        questText.text = "Humble Beginnings";
        questButton.onClick.AddListener(ButtonClickHandler);
    }

    void ButtonClickHandler(){
        isQuestActive = true;
        SetTrackerText();
        Debug.Log("Button Clicked");
    }

    public void SetTrackerText(){
        if(questNumber == 1){
            killsNeeded = 1;
            trackerText.text = "Humble Beginnings";
            trackerTextSubtext.text = killedQuestEnemies + "/" + killsNeeded + " Enemies Killed";
        }
    }
}
