using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Item item;
    public Image image;
    public void UseItem()
    {
        Debug.Log("Click a " + gameObject.name);
        if (item != null)
        {
            item.Use();
            Inventory.Instance.Remove(item);
        }
    }

    public void Set(Item item)
    {
        this.item = item;
        image.sprite = item.inventoryIconSprite;
    }

    public void Clear()
    {
        this.item = null;
        image.sprite = null;
    }
}
