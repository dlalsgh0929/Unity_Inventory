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
        //slotParents의 자식들을 slots 리스트에 할당
        slots = new List<UISlot>(slotParants.GetComponentsInChildren<UISlot>());
        
        // 아이템 리스트에 있는 아이템들을 slots 리스트에 전달
        for(int i = 0; i < slots.Count && i< items.Count; i++)
        {
            slots[i].Item = items[i];
        }

        // 나머지 리스트의 슬롯은 NULL로 채우기
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
