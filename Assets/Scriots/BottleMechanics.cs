using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BottleMechanics : MonoBehaviour
{
    public XRGrabInteractable bottleCap;
    public XRGrabInteractable bottle;
    
    bool isGrabbed;

    private void Start() 
    {
        bottleCap = GetComponent<XRGrabInteractable>();
        bottleCap.enabled = false;
    }

    void Update()
    {
        if(bottle.isSelected)
        {
            isGrabbed = true;
        } else {
            isGrabbed = false;
        }

        if(isGrabbed)
        {
            IsGrabbed();
        }
    }

    public void IsGrabbed()
    {
        if(isGrabbed)
        {
            bottleCap.enabled = true;
        }
    }
}
