using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarInventario : Interactable
{
    Canvas myCanvas;

    void Start()
    {
        myCanvas = GetComponent<Canvas>();
    }

    public override void InventoryInteract()
    {
        base.InventoryInteract();
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            myCanvas.enabled = !myCanvas.enabled;
        }
    }
}
