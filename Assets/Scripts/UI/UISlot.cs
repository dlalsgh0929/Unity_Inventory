using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    public Image image;
    public GameObject isEquiped; // ����ǥ�� �̹���

    private Item item;
    public Item Item
    {
        get { return item; }
        set
        {
            item = value;
            // ���Կ� �������� �ִٸ�
            if (item != null)
            {
                // �ش� ������ �̹��� ǥ��
                image.sprite = item.itemImage; 
                image.color = new Color(1, 1, 1, 1);
            }
            else
            {
                // ���ٸ� slotItem�� �̹��� ����ȭ
                image.color = new Color(1, 1, 1, 0);
            }
        }
    }

    // ��ư �������� �Ǿ� �ִ� ������ ������ ������ ȣ�ߵǴ� �޼���
    public void ItemEquip()
    {
        if (item == null) return;
        isEquiped.SetActive(!isEquiped.activeSelf);
        item.isEquip = !item.isEquip;
        GameManager.Instance.SetEquipItemStats(item);
    }
}
