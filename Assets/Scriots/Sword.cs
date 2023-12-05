using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.OpenXR.NativeTypes;
using TMPro;

public class Sword : XRBaseInteractor
{
    public Player player;
    public float swordDamage = 5f;

    protected override void Start()
    {
        gameObject.tag = "Sword";
    }
    // Update is called once per frame
    void Update()
    {
        swordDamage += player.baseDamage;
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Enemy")
        {
            Debug.Log("Collision Detected");
        }        
    }
}
