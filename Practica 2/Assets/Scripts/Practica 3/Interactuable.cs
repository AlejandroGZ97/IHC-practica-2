using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactuable : MonoBehaviour
{
    private bool enZona = false;
    private TextMesh tm;
   
    void Start()
    {
        tm = GetComponent<TextMesh>();
    }

    public void mostararMens()
    {
        if (enZona)
            tm.text = "Interactua con E";
        else
            tm.text = "";
    }

    void Update()
    {
        mostararMens();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Interactuable"))
            enZona = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Interactuable"))
            enZona = false;
    }
}
