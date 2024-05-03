using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class Interaction : MonoBehaviour
{
    public string itemName;
    private bool isCursorOverObject;
    public float interactionDistance = 5f; 
    private GUIStyle guiStyle = new GUIStyle();

    public GameObject crosshair;

    void Start()
    {        
        guiStyle.fontStyle = FontStyle.Bold;
        guiStyle.normal.textColor = Color.white;
        guiStyle.fontSize = 60;
    }

     
    void Update()
    {
       
        Vector3 crosshairPosition = crosshair.transform.position;

       
        Ray ray = Camera.main.ScreenPointToRay(crosshairPosition);
        RaycastHit hit;

       
        if (Physics.Raycast(ray, out hit, interactionDistance))
        {
            isCursorOverObject = hit.collider.gameObject == gameObject;
        }
        else
        {
            isCursorOverObject = false;
        }
    }

    void OnGUI()
    {
        if (isCursorOverObject)
        {
            
            Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);

           
            GUI.Label(new Rect(screenPos.x, Screen.height - screenPos.y, 150f, 30f), itemName, guiStyle);
        }
    }
}
