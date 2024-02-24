using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class DoorToggle : MonoBehaviour
{
     public Animator doorAnimator; // Assign Animator in the Unity Editor


    void Start()
    {
    // Add a listener to the selectEntered event of the XRSimpleInteractable        
    GetComponent<XRSimpleInteractable>().selectEntered.AddListener(args => ToggleDoor());
    }


    void ToggleDoor()
    {
        // Toggle the "Open" parameter of the door’s Animator
        doorAnimator.SetBool("Open", !doorAnimator.GetBool("Open"));
    }
}


