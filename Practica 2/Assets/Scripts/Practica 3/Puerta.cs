using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : Interactable
{
    public Vector3 ejeRotacion;
    private bool banderaPuerta = true;
    private Transform tm;
    private AudioSource audioSource;
    public AudioClip[] clips;

    void Start()
    {
        tm = GetComponent<Transform>();
        audioSource = GetComponent<AudioSource>();
    }

    public override void Interact()
    {
        base.Interact();
        if (banderaPuerta)
        {
            tm.position = new Vector3(tm.position.x - 1f,tm.position.y, tm.position.z + 1f);
            ejeRotacion.y = 1f;
            transform.Rotate(ejeRotacion, 90f);
            banderaPuerta = false;
            audioSource.clip = clips[0];
            audioSource.Play();
        }
        else
        {
            tm.position = new Vector3(tm.position.x + 1f,tm.position.y, tm.position.z - 1f);
            ejeRotacion.y = -1f;
            transform.Rotate(ejeRotacion, 90f);
            banderaPuerta = true;
            audioSource.clip = clips[1];
            audioSource.Play();
        }
        
    }
}
