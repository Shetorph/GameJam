using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Level1 : MonoBehaviour
{
    public GameObject anahtar,anahtar2,kup,kapi;
    public Collider anahtarKoy;
     void Update() {
        tpKapisi();
    }
    void tpKapisi(){ 
        if(anahtar.activeSelf == false)
        {
           anahtarKoy.enabled = true;
        }
        
        if(kup.activeSelf == false)
        {
            anahtar2.SetActive(true);
        }
        if(anahtar2.activeSelf == true)
        {
            kapi.SetActive(true);
        }
    }
    
}
