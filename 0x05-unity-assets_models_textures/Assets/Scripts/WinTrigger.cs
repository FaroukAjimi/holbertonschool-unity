﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    void OnTriggerEnter()
    {
        GameObject player = GameObject.Find("Player");
        player.GetComponent<Timer>().TimerText.fontSize = 70;
        player.GetComponent<Timer>().TimerText.color = Color.green;
        (GameObject.Find("Player").GetComponent("Timer") as MonoBehaviour).enabled = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
