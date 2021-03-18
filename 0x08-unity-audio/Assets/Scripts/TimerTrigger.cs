using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        (GameObject.Find("Player").GetComponent("Timer") as MonoBehaviour).enabled = true;
    }
    // Start is called before the first frame update
    void Start()
    {
    }
}
