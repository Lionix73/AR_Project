using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLScript : MonoBehaviour
{
    public string url;

    void Start()
    {
        
    }

    public void OpenURL(){
        Application.OpenURL(url);
    }
}
