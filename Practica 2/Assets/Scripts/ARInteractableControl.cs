using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARInteractableControl : MonoBehaviour
{
    [SerializeField] private GameObject punto;
    [SerializeField] private float velocidad;
    private bool leftRight = false;
    private Vector3 posicion2;
    private Transform tm;

    void Start()
    {
        tm = GetComponent<Transform>();
        posicion2 = tm.position;
    }
    void OnMouseDown() 
    {
        Debug.Log($"Interactuando con {name}");

        float step = velocidad * Time.deltaTime;
        leftRight = !leftRight;
        if (leftRight)
        {
            tm.position = Vector3.MoveTowards(tm.position, punto.transform.position, step);
        }
        else
            tm.position = Vector3.MoveTowards(tm.position, posicion2, step);
    }
}
