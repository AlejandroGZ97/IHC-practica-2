using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransportar : Interactable
{
    [SerializeField] public GameObject Player;
    [SerializeField] public GameObject destino;

    public override void Interact()
    {
        base.Interact();
        Player.transform.position = destino.transform.position;
    }
}
