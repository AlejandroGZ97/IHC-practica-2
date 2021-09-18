using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : Interactable
{
    public Vector3 ejeRotacion;

    public override void Interact()
    {
        base.Interact();
        transform.Rotate(ejeRotacion, 40f);
        
        transform.localScale = new Vector3(Random.Range(0.9f,2f),Random.Range(0.9f,2f),Random.Range(0.9f,2f));
    }
}
