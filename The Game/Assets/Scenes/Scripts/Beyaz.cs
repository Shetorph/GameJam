using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliders2 : MonoBehaviour
{
    public Collider beyaz;
   void Update()
    {
        if(Input.GetMouseButton(0))
        {
           beyaz.enabled = false;
        }

        if(Input.GetMouseButton(1))
        {
           beyaz.enabled = true;
        }

    }
}
