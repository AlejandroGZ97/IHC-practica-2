using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

[CreateAssetMenu(fileName = "Shield Battery", menuName = "Inventory/Objeto/Battery")]

public class ShieldBattery : Item
{
    [Range(1f,10f)]
    private float speedGain = 5f;
    private float jumpGain = 3f;

    private FirstPersonController _player;

    public override void Use()
    {
        base.Use();
        _player = FindObjectOfType<FirstPersonController>();
        _player.MoveSpeed += speedGain;
        _player.SprintSpeed += speedGain;
        _player.JumpHeight += jumpGain;
        //Subir escudo al personaje, mas que shield cell
    }
}
