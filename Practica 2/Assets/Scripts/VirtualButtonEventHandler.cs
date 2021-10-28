using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonEventHandler : MonoBehaviour
{
    public GameObject ButtonObj;
    public VirtualButtonBehaviour vb;
    [SerializeField] private GameObject modelo1;
    [SerializeField] private GameObject modelo2;
    [SerializeField] private GameObject modelo3;
    private Vector3 setScale;
    int cont = 0;

    // Start is called before the first frame update
    void Start()
    {
        vb.RegisterOnButtonPressed(OnButtonPressed);
        vb.RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Pressed");
        if (cont == 0)
        {
            setScale = modelo1.transform.localScale;
            modelo1.transform.localScale = modelo2.transform.localScale;
            modelo2.transform.localScale = setScale;
            cont = 1;
        }
        else if (cont == 1)
        {
            setScale = modelo2.transform.localScale;
            modelo2.transform.localScale = modelo1.transform.localScale;
            modelo3.transform.localScale = setScale;
            cont = 2;
        }
        else
        {
            setScale = modelo3.transform.localScale;
            modelo3.transform.localScale = modelo1.transform.localScale;
            modelo1.transform.localScale = setScale;
            cont = 0;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Realesed");
    }
}
