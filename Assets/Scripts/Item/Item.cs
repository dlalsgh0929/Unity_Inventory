using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    WEAPON,
    TOP,
    BOTTOMS
}

[CreateAssetMenu]
public class Item : ScriptableObject
{
    public string itemName;
    public ItemType itemType;
    public Sprite itemImage;
    public int attack;
    public int defend;
    public bool isEquip;
}
