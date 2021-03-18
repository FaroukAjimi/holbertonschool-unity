using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steps : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip clip;
    public AudioClip splash;
    public AudioSource[] asource;
    void Start()
    {
    }
    // Update is called once per frame
    void Step()
    {
        Debug.Log("hello");
        asource[0].PlayOneShot(clip);
    }
    void Fall()
    {
        asource[1].PlayOneShot(clip);
    }
}