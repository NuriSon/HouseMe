using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class MovementController : MonoBehaviour
{
     [System.Serializable]
    public class Movement
    {
        public string currentMovement;
        public double nextTimeline;
        public bool hasBeenPlayed;


        public Movement(string currentMovement, double nextTimeline)
        {
            this.currentMovement = currentMovement;
            this.nextTimeline = nextTimeline;
            hasBeenPlayed = false;
        }
    }


    public PlayableDirector playableDirector;
    public List<Movement> movements = new List<Movement>();


    public void InputCurrentMovement(string currentMovement)
    {
        Movement nextMovement = movements.Find(movement => movement.currentMovement == currentMovement);


        if (nextMovement != null && !nextMovement.hasBeenPlayed)
        {
            playableDirector.Pause();
            playableDirector.time = nextMovement.nextTimeline;
            playableDirector.Play();
            nextMovement.hasBeenPlayed = true;
        }
        else
        {
            Debug.LogWarning("Movement not found or already played.");
        }
    }
}

