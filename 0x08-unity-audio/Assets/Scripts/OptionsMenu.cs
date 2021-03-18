using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class OptionsMenu : MonoBehaviour
{
    public AudioMixer amg;
    // Start is called before the first frame update
    public void SetLevel (float sliderValue)
    {
        amg.SetFloat ("MusicVol", Mathf.Log10(sliderValue) * 20);
    }
    public void Sfx(float sliderValue)
    {
        amg.SetFloat ("MusicVol1", Mathf.Log10(sliderValue) * 20);
        amg.SetFloat ("MusicVol2", Mathf.Log10(sliderValue) * 20);
        amg.SetFloat ("MusicVol3", Mathf.Log10(sliderValue) * 20);
    }
    public void Back(){
    SceneManager.LoadScene(PlayerPrefs.GetInt("LastLevel"));
    }
    public void Apply(){
        
    }
}
