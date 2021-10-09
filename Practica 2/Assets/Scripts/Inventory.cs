using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    static protected Inventory _instance;
    static public Inventory Instance {get {return _instance;}}
    public delegate void OnChange();
    public OnChange onChange;
    [SerializeField] public List<Item> items = new List<Item>();
    public int space = 14;

    void Awake() {
        _instance = this;
    }

    public void Add(Item item)
    {
        if (items.Count < space)
        {
            items.Add(item);
            if (onChange != null)
            {
                onChange.Invoke();
            }
        }
        else
        {
            Debug.LogWarning("No hay mas espacio en el inventario");
        }
    }

    public void Remove(Item item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            if (onChange != null)
            {
                onChange.Invoke();
            }
        }
        else
        {
            Debug.LogWarning("El item no se encotro en el inventario");
        }
    }
}
