using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class XRSocketTreasureInteractor : XRSocketInteractor
{


    public string treasureTag = "Treasure";


   public override bool CanHover(IXRHoverInteractable interactable)
    {
        // Check if the interactable object has the treasure tag
        return base.CanHover(interactable) && interactable.transform.CompareTag(treasureTag);
    }


    public override bool CanSelect(IXRSelectInteractable interactable)
    {
        // Check if the interactable object has the treasure tag
        return base.CanSelect(interactable) && interactable.transform.CompareTag(treasureTag);
    }


}
