using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Player : MonoBehaviour
{
    public UnityEvent<GameObject> OnPlayerEnterEvent;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            OnPlayerEnterEvent.Invoke(other.gameObject);
          
        }
    }


}

