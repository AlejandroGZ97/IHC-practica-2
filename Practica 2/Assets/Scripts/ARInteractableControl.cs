using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARInteractableControl : MonoBehaviour
{
    [SerializeField] private Vector3 setPosition;
    
    void OnMouseDown() 
    {
        Debug.Log($"Interactuando con {name}");

        setPosition.x = Random.Range(-0.06f, 0.07f);
        setPosition.z = Random.Range(-0.05f, 0.03f);
        transform.localPosition = setPosition;
    }
}
