using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private bool insideInteractionZone = false;
    public bool canBeSave = true;
    public Item inventoryItem;

    public virtual void Interact()
    {
        Debug.Log("Interactuando");
    }

    public virtual void Interact2() {}
    public virtual void InventoryInteract() {}

    void Update()
    {
        InventoryInteract();                
        if (insideInteractionZone)
        {
            Interact2();
            if (Input.GetKeyDown(KeyCode.E))
            {
                Interact();
            }
            else if (canBeSave && Input.GetKeyDown(KeyCode.F))
            {
                //Guardar en inventario
                if (inventoryItem != null)
                {
                    Inventory.Instance.Add(inventoryItem);
                    Destroy(gameObject);
                }
                
            }
        }
            
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