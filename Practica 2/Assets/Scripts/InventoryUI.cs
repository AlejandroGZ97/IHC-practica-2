using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    private Inventory _inventory;

    void Start() 
    {
        _inventory = Inventory.Instance;
        _inventory.onChange += UpdateUI;
    }

    void UpdateUI()
    {
        InventorySlot[] slots = GetComponentsInChildren<InventorySlot>();
        
        for(int i=0; i<slots.Length; i++)
        {
            if (i < _inventory.items.Count)
            {
                slots[i].Set(_inventory.items[i]);
            }
            else
            {
                slots[i].Clear();
            }
        }
    }
}
