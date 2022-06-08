using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crosshair : MonoBehaviour
{

    public Slider forceBar;

    private bool mouseHeld;
    
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            mouseHeld = true;
            forceBar.value += 0.5f;
        }
        else{
            mouseHeld = false;
            forceBar.value = 0;
        }
    }
}
