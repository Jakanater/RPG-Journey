using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;
using UnityEngine.UI;
public class Quests : MonoBehaviour
{
    public Button questButton;
    public TextMeshProUGUI questText;
    public TextMeshProUGUI trackerText;
    public TextMeshProUGUI trackerTextSubtext;

    public int questNumber = 1;
    public int killedQuestEnemies = 0;

    public bool isQuestActive;

    void Start(){
        questText.text = "Humble Beginnings";
        questButton.onClick.AddListener(ButtonClickHandler);
    }

    void ButtonClickHandler(){
        isQuestActive = true;
    }

    public void SetTrackerText(){
        if(questNumber == 1){
            trackerText.text = "Humble Beginnings";
            trackerTextSubtext.text = killedQuestEnemies + "/1 Enemies Killed";
        }
    }
}
