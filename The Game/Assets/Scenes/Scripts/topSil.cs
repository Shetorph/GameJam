using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topSil : MonoBehaviour
{
    void OnCollisionEnter(Collision x) {
        if(x.collider.tag == "yandin")
        {
            Object.Destroy(this.gameObject);
        }
    }
}
