using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start(){
        PlayerPrefs.SetInt ("LastLevel", SceneManager.GetActiveScene().buildIndex);
    }
    // Start is called before the first frame update
    public void LevelSelect(int level)
    {
        SceneManager.LoadScene("Level0" + level);
    }
    public void Exit(){
        Debug.Log("Exited");
        Application.Quit();
    }
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
  
}
