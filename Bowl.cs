using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Bowl : MonoBehaviour
{
    public UnityEvent<GameObject> OnTreasureEnterEvent;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Treasure"))
        {
            OnTreasureEnterEvent.Invoke(other.gameObject);
            CollectTreasure(other.gameObject);
        }
    }


    private void CollectTreasure(GameObject treasure)
    {
        treasure.SetActive(false);
        // Add any additional actions here, such as playing sounds, animations, or incrementing score.
    }
}
