using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
    public AudioMixerSnapshot snap1;
    public AudioMixerSnapshot snap2;
    public static bool GameIsPaused = false;
    public GameObject pm;
    void Start(){
        pm.SetActive(false);
    }
    void Update(){
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                snap2.TransitionTo(.01f);
                Resume();
            }
            else
            {
                snap1.TransitionTo(.01f);
                Pause();
            }
        }
    }
    public void Resume(){
        pm.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void Pause(){
        pm.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.Confined;
    }
    public void Options(){
        PlayerPrefs.SetInt ("LastLevel", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("Options");
    }
    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}
