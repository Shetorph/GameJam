using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birlestir : MonoBehaviour
{
    public GameObject kristal,kristal1,kristal2,kristal3,birlestirr;
    
     void Update() {
       if(kristal.activeSelf == true && kristal1.activeSelf == true && kristal2.activeSelf == true && kristal3.activeSelf == true)
       {
         birlestirr.SetActive(true);
       } 
    }
    
}
