using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class topCarpma : MonoBehaviour
{
    void OnCollisionEnter(Collision x)
    {
        if(x.gameObject.tag =="Player")
        {
            SceneManager.LoadScene(3);
        }
    }
}
