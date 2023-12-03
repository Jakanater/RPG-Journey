using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.UI;
using TMPro; 
public class ExperiencePoints : MonoBehaviour
{
    public Image xpThing;
    public TextMeshProUGUI level;
    public HealthBar healthBar;

    public int xpLevel = 1;
    public float[] xpNeeded;
    public float currentXP = 0;

    void Update()
    {
//
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ChangeXP(400);
        }
    }
    public void ChangeXP(float xpGained)
    {   
        currentXP += xpGained;
        float currentXPDisplayed = currentXP;
        if(currentXP == xpNeeded[xpLevel - 1])
        {
            // Debug.Log("BAlls");
            xpLevel++;
            currentXPDisplayed = 0;
            Debug.Log(currentXPDisplayed);
        } else if(currentXP > xpNeeded[xpLevel - 1] && currentXP < xpNeeded[xpLevel])
        {
            // Check for extra levels
            xpLevel++;
            Debug.Log(currentXPDisplayed);
        } else if(currentXP > xpNeeded[xpLevel - 1] && currentXP > xpNeeded[xpLevel])
        {
            xpLevel += 2;
        }
        float maxXP = xpNeeded[xpLevel - 1];
        if(xpLevel > 1)
        {
            // Debug.Log("currentXPDisplayed: " + currentXPDisplayed);
            currentXPDisplayed -= xpNeeded[xpLevel - 2];
            maxXP -= xpNeeded[xpLevel - 2];
        }
        Debug.Log("currentXPDisplayed: " + currentXPDisplayed + "/maxXP; " + maxXP);
        xpThing.fillAmount = currentXPDisplayed/maxXP;
        level.text = xpLevel.ToString();
    }
}
