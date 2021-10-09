using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

[CreateAssetMenu(fileName = "MedKit", menuName = "Inventory/Objeto/MedKit")]

public class MedKit : Item
{
    [Range(1f,10f)]
    private float loosGravity = 5f;
    private float increaseSpeedChangeRate = 4f;

    private FirstPersonController _player;

    public override void Use()
    {
        base.Use();
        _player = FindObjectOfType<FirstPersonController>();
        _player.Gravity += loosGravity;
        _player.SpeedChangeRate += increaseSpeedChangeRate;
        //Subir vida al personaje, mas que syringe
    }
}
