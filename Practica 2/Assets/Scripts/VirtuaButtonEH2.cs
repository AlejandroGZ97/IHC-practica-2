using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtuaButtonEH2 : MonoBehaviour
{
    public GameObject cubo;
    public VirtualButtonBehaviour vb;
    private AudioSource audioSource;
    private Color color;

    // Start is called before the first frame update
    void Start()
    {
        vb.RegisterOnButtonPressed(OnButtonPressed);
        vb.RegisterOnButtonReleased(OnButtonReleased);
        audioSource = cubo.GetComponent<AudioSource>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Pressed");

        color = new Color(Random.value, Random.value, Random.value);
        cubo.GetComponent<Renderer>().material.color = color;
        audioSource.Play();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Realesed");

        color = new Color(Random.value, Random.value, Random.value);
        cubo.GetComponent<Renderer>().material.color = color;
        audioSource.Stop();
    }
}
