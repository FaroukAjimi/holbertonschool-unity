using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redirect : MonoBehaviour
{
    // Start is called before the first frame update
    public string url;
    public void Open()
    {
        Application.OpenURL(url);
    }
}
