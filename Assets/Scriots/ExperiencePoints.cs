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
        ChangeXP(0);
    }

    public void ChangeXP(float xpGained)
    {   
        if(currentXP == xpNeeded[xpLevel - 1])
        {
            // Debug.Log("BAlls");
            xpLevel++;
        } else if(currentXP > xpNeeded[xpLevel - 1])
        {
            // Check for extra levels
        }
        currentXP += xpGained;
        float maxXP = xpNeeded[xpLevel - 1];
        float cXP = currentXP;
        if(xpLevel > 1)
        {
            cXP -= xpNeeded[xpLevel - 2];
        }
        xpThing.fillAmount = cXP/maxXP;
        // Debug.Log(currentXP);
        level.text = xpLevel.ToString();
    }
}
