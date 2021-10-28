using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARInteractable : Interactable
{
    [SerializeField] private GameObject modelo1;
    [SerializeField] private GameObject modelo2;
    [SerializeField] private GameObject modelo3;
    private Vector3 setScale;
    int cont = 0;
    
    void OnMouseDown() 
    {
        Debug.Log($"Interactuando con {name}");
        
        if (cont == 0)
        {
            setScale = modelo1.transform.localScale;
            modelo1.transform.localScale = modelo2.transform.localScale;
            modelo2.transform.localScale = setScale;
            cont = 1;
        }
        else if (cont == 1)
        {
            setScale = modelo2.transform.localScale;
            modelo2.transform.localScale = modelo1.transform.localScale;
            modelo3.transform.localScale = setScale;
            cont = 2;
        }
        else
        {
            setScale = modelo3.transform.localScale;
            modelo3.transform.localScale = modelo1.transform.localScale;
            modelo1.transform.localScale = setScale;
            cont = 0;
        }
    }
}
