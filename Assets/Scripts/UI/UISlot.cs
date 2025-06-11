using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    public Image image;
    public GameObject isEquiped; // 장착표시 이미지

    private Item item;
    public Item Item
    {
        get { return item; }
        set
        {
            item = value;
            // 슬롯에 아이템이 있다면
            if (item != null)
            {
                // 해당 아이템 이미지 표시
                image.sprite = item.itemImage; 
                image.color = new Color(1, 1, 1, 1);
            }
            else
            {
                // 없다면 slotItem의 이미지 투명화
                image.color = new Color(1, 1, 1, 0);
            }
        }
    }

    // 버튼 형식으로 되어 있는 아이템 슬롯을 누르면 호추되는 메서드
    public void ItemEquip()
    {
        if (item == null) return;
        isEquiped.SetActive(!isEquiped.activeSelf);
        item.isEquip = !item.isEquip;
        GameManager.Instance.SetEquipItemStats(item);
    }
}
