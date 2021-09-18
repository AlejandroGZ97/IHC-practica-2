using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private bool insideInteractionZone = false;

    public virtual void Interact()
    {
        Debug.Log("Interactuando");
    }

    public virtual void Interact2() {}

    void Update()
    {
        if (insideInteractionZone && Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
        if (insideInteractionZone)
            Interact2();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Entró a el area");
            insideInteractionZone = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Salió del area");
            insideInteractionZone = false;
        }
    }
}