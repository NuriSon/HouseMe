using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureCollector : MonoBehaviour
{
    private void Start()
    {
        GetComponent<TriggerZone>().OnEnterEvent.AddListener(InsideTreasureCollector);
    }

    public void InsideTreasureCollector(GameObject go)
    {
        go.SetActive(false);
    }
}
