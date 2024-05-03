using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    Outline outline;
    public string message;

    public UnityEvent onInteraction;

    public void Interact()
    {
        onInteraction.Invoke();
    }
}
