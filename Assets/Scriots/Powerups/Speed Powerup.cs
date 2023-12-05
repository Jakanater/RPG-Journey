using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class SpeedPowerup : MonoBehaviour
{
    public Player player;
    public InputActionProperty speedButton;
    bool isSpeedPressed;

    void Update()
    { 
        Debug.Log("Speed button value: " + speedButton.action.ReadValue<float>());
        isSpeedPressed = speedButton.action.ReadValue<float>() > 0.5f;
        SpeedPowerup1();
    }

    private void SpeedPowerup1()
    {
        Debug.Log("ge");
        if(isSpeedPressed)
        {
            Debug.Log("feasfeasfeasfeasfeasfeasfeasf");
            player.speed = 10f;
        }
    }
}