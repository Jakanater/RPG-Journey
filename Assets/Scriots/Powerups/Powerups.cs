using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class SpeedPowerup : MonoBehaviour
{
    public ActionBasedContinuousMoveProvider move;
    public Player player;
    public InputActionReference speedButton;
    public InputActionReference attackPButton;
    bool isSpeedPressed;

    private void Awake() {
        speedButton.action.started += SpeedPowerup1;
        attackPButton.action.started += DamagePowerup;
    }

    private void SpeedPowerup1(InputAction.CallbackContext ctx)
    {
        Debug.Log("Speed Mode Activated");
        move.moveSpeed = 10f;
    }

    private void DamagePowerup(InputAction.CallbackContext ctx)
    {
        player.baseDamage += 10;
    }
}