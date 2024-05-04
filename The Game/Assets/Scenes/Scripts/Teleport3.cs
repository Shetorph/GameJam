using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public int sceneID = 4;
    void OnTriggerEnter(Collider x) {
        if(x.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(sceneID);
        }        
    }
}
