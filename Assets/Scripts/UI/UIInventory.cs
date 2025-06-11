using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    public List<Item> items;

    [SerializeField] UISlot _uiSlot;
    [SerializeField] Transform slotParants;
    [SerializeField] List<UISlot> slots;

    private void Start()
    {
        InitInventoryUI();
    }

    public void InitInventoryUI()
    {
        //slotParents�� �ڽĵ��� slots ����Ʈ�� �Ҵ�
        slots = new List<UISlot>(slotParants.GetComponentsInChildren<UISlot>());
        
        // ������ ����Ʈ�� �ִ� �����۵��� slots ����Ʈ�� ����
        for(int i = 0; i < slots.Count && i< items.Count; i++)
        {
            slots[i].Item = items[i];
        }

        // ������ ����Ʈ�� ������ NULL�� ä���
        for(int i = items.Count; i < slots.Count; i++)
        {
            slots[i].Item = null;
        }
    }

    public void GoMainMenu()
    {
        gameObject.SetActive(false);
        UIManager.Instance.MainMenu.statusButton.gameObject.SetActive(true);
        UIManager.Instance.MainMenu.inventoryButton.gameObject.SetActive(true);
    }

}
