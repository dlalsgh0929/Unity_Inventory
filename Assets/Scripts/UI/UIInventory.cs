using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoMainMenu()
    {
        gameObject.SetActive(false);
        UIManager.Instance.MainMenu.statusButton.gameObject.SetActive(true);
        UIManager.Instance.MainMenu.inventoryButton.gameObject.SetActive(true);
    }
}
