using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birlestir : MonoBehaviour
{
    public GameObject kristal,kristal1,kristal2,kristal3,birlestirr;
    
     void Update() {
       if(kristal.activeSelf == false && kristal1.activeSelf == false && kristal2.activeSelf == false && kristal3.activeSelf == false)
       {
         birlestirr.SetActive(true);
       } 
    }
    
}
