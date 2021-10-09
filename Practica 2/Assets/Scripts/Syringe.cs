using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

[CreateAssetMenu(fileName = "Syringe", menuName = "Inventory/Objeto/Syringe")]

public class Syringe : Item
{
    [Range(1f,10f)]
    private float loosGravity = 2f;

    private FirstPersonController _player;

    public override void Use()
    {
        base.Use();
        _player = FindObjectOfType<FirstPersonController>();
        _player.Gravity += loosGravity;
        //Subir vida al personaje
    }
}
