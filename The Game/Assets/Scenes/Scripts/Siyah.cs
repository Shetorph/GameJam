using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Colliders : MonoBehaviour
{
    public BoxCollider siyah;
   void Update()
    {
        if(Input.GetMouseButton(0))
        {
           siyah.enabled = true;
        }

        if(Input.GetMouseButton(1))
        {
           siyah.enabled = false;
        }

    }
}
