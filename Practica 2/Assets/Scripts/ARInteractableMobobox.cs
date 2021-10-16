using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARInteractableMobobox : Interactable
{
    private AudioSource audioSource;
    private bool playStop = false;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnMouseDown() 
    {
        Debug.Log($"Interactuando con {name}");
        playStop = !playStop;
        if (playStop)
            audioSource.Play();
        else
            audioSource.Stop();
    }
}
