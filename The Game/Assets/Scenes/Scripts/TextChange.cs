using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    public GameObject txtTutorial1, txtTutorial2;
    public Text txtTutorialQuest;
    public string txtQuest;

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            txtTutorial1.SetActive(false);
            txtTutorial2.SetActive(true);
            txtTutorialQuest.text = txtQuest;
        }
    }
}
