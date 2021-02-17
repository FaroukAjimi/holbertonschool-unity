using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pm;
    void Update(){
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
                Resume();
            else
            {
                Debug.Log("log");
                Pause();
            }
        }
    }
    public void Resume(){
        pm.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Pause(){
        pm.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
