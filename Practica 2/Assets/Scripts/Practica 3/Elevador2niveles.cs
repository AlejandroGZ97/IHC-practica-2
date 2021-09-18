using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevador2niveles : Interactable
{
    [SerializeField] private GameObject punto;
    [SerializeField] private float velocidad;
    private bool banderaElevador = false;
    private Vector3 posicion2;

    private Transform tm;

    void Start()
    {
        tm = GetComponent<Transform>();
        posicion2 = tm.position;
    }

    public override void Interact2()
    {
        base.Interact2();
        float step = velocidad * Time.deltaTime;
        
        if (Input.GetKeyDown(KeyCode.E))
            banderaElevador = !banderaElevador;
        
        if (banderaElevador)
            tm.position = Vector3.MoveTowards(tm.position, punto.transform.position, step);
        else
            tm.position = Vector3.MoveTowards(tm.position, posicion2, step);
    }
}
