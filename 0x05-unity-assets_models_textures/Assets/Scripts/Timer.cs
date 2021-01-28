using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text TimerText;
    private float startTime;
    
    // Start is called before the first frame update
    void Start()
    {
        TimerText.text = "0:00.00";
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {        
        float t = Time.time - startTime;
        string min = ((int) t / 60).ToString();
        string sec = (t % 60).ToString("00.00");
        TimerText.text = min + ":" + sec;
    }
}
