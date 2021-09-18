using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balon : Interactable
{
    public Vector3 forceVector;
    private Rigidbody rb;
    private Color color;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public override void Interact()
    {
        base.Interact();
        color = new Color(Random.value, Random.value, Random.value);
        GetComponent<Renderer>().material.color = color;
        rb.AddForce(forceVector, ForceMode.Force);
    }
}