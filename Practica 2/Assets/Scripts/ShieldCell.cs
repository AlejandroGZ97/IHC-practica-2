using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

[CreateAssetMenu(fileName = "Shield Cell", menuName = "Inventory/Objeto/Cell")]

public class ShieldCell : Item
{
    [Range(1f,10f)]
    private float speedGain = 1f;

    private FirstPersonController _player;

    public override void Use()
    {
        base.Use();
        _player = FindObjectOfType<FirstPersonController>();
        _player.MoveSpeed += speedGain;
        _player.SprintSpeed += speedGain;
        //Subir escudo al personaje
    }
}
