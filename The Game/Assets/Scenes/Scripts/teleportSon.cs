using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleportSon : MonoBehaviour
{
    void OnTriggerEnter(Collider x) {
        if(x.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(3);
        }        
    }
}
