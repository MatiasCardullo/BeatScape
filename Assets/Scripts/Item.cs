
using UnityEngine;
using System.Diagnostics.CodeAnalysis;

public enum ItemType
{
    Consumible,
    Equipment,
    Cartridge
}

public abstract class Item : ScriptableObject
{
    public Sprite sprite;
    //public GameObject prefab;
    public ItemType type;
    private int id;

    [TextArea(1, 10)]
    public string description;
    public void Awake()
    {
        id = GetInstanceID();
    }

    public virtual bool Use()
    {
        Debug.Log("Using item "+ name);
        return true;
    }
}
