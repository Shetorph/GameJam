using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.UI;

public class renkdegisme : MonoBehaviour
{
    public GameObject yinyangrenk;
    
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
           yinyangrenk.GetComponent<Image>().color = new Color32(0,0,0,255);
        }

        if(Input.GetMouseButton(1))
        {
            yinyangrenk.GetComponent<Image>().color = new Color32(255,255,255,255);
        }
    }
}
