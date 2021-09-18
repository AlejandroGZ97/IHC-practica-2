using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrito : Interactable
{
    [SerializeField] private GameObject punto;
    [SerializeField] private float velocidad;
    private AudioSource audioSource;
    public AudioClip[] clips;

    private Transform tm;

    void Start()
    {
        tm = GetComponent<Transform>();
        audioSource = GetComponent<AudioSource>();
    }

    public override void Interact2()
    {
        base.Interact2();
        float step = velocidad * Time.deltaTime;
        if (!audioSource.isPlaying)
        {
            audioSource.clip = clips[0];
            audioSource.Play();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            audioSource.clip = clips[1];
            audioSource.Play();
            velocidad += 1;
        }
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
            tm.Rotate(tm.rotation.x, tm.rotation.y + 15f, tm.rotation.z);
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            tm.Rotate(tm.rotation.x, tm.rotation.y - 15f, tm.rotation.z);
        
        tm.position = Vector3.MoveTowards(tm.position, punto.transform.position, step);
    }
}
