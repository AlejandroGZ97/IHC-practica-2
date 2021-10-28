using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARInteractableMobobox : Interactable
{
    private AudioSource audioSource;
    private bool playStop = false;
    private Color color;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    void OnMouseDown() 
    {
        Debug.Log($"Interactuando con {name}");

        color = new Color(Random.value, Random.value, Random.value);
        GetComponent<Renderer>().material.color = color;
        playStop = !playStop;
        if (playStop)
            audioSource.Play();
        else
            audioSource.Stop();
    }
}
