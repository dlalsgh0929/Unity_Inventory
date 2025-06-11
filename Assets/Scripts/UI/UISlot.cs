using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    public Image image;
    public GameObject isEquiped;

    private Item item;
    public Item Item
    {
        get { return item; }
        set
        {
            item = value;
            if (item != null)
            {
                image.sprite = item.itemImage;
                image.color = new Color(1, 1, 1, 1);
            }
            else
            {
                image.color = new Color(1, 1, 1, 0);
            }
        }
    }

    public void ItemEquip()
    {
        if (item == null) return;
        isEquiped.SetActive(!isEquiped.activeSelf);
        item.isEquip = !item.isEquip;
        GameManager.Instance.SetEquipItemStats(item);
    }
}
