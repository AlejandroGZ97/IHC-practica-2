using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARInteractable : Interactable
{
    public Vector3 ejeRotacion;
    
    void OnMouseDown() 
    {
        Debug.Log($"Interactuando con {name}");
        transform.Rotate(ejeRotacion, 40f);
        transform.localScale = new Vector3(Random.Range(0.9f,2f),Random.Range(0.9f,2f),Random.Range(0.9f,2f));
    }
}
