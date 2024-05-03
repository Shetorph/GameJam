using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    public GameObject txtBasicMovement, txtExtras;

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            txtBasicMovement.SetActive(false);
            txtExtras.SetActive(true);
        }
    }
}
