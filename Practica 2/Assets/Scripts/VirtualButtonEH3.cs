using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonEH3 : MonoBehaviour
{
    public GameObject ButtonObj;
    public VirtualButtonBehaviour vb;
    [SerializeField] private Vector3 setPosition;

    // Start is called before the first frame update
    void Start()
    {
        vb.RegisterOnButtonPressed(OnButtonPressed);
        vb.RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Pressed");

        setPosition.x = Random.Range(-0.06f, 0.07f);
        setPosition.z = Random.Range(-0.05f, 0.03f);
        ButtonObj.transform.localPosition = setPosition;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Realesed");
    }
}
