using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    public Animator anim;
    public GameObject plyer;
    public GameObject mC;
    public GameObject tC;
    public GameObject cS;
    // Start is called before the first frame update
    void Start()
    {
            plyer.GetComponent<PlayerController>().enabled = false;
            mC.SetActive(false);
            tC.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Intro01") == false)
        {
            plyer.GetComponent<PlayerController>().enabled = true;
            mC.SetActive(true);
            tC.SetActive(true);
            cS.SetActive(false);
        }
    }
}
