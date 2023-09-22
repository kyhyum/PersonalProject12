using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Resource,
    Equipable
}

public enum ItemEffect
{
    None,
    Attack,
    Armor
}

[CreateAssetMenu(fileName = "Item", menuName = "New Item", order = 1)]
public class ItemSO : ScriptableObject
{
    [Header("Info")]
    public string displayName;
    public string description;
    public ItemType type;
    public ItemEffect effect;
    public int plusValue;
    public bool isEquiped;
    public Sprite icon;

}
