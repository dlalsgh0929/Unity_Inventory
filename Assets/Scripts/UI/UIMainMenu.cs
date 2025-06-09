using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    public Button statusButton;
    public Button inventoryButton;

    public TextMeshProUGUI jobText;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI levelText;



    public void SetCharacterInfo()
    {
        jobText.text = GameManager.Instance.Character.job;
        nameText.text = GameManager.Instance.Character.name;
        levelText.text = $"Lv. {GameManager.Instance.Character.level}";
    }




    public void OpenStatusUI()
    {
        statusButton.gameObject.SetActive(false);
        inventoryButton.gameObject.SetActive(false);
        UIManager.Instance.Status.gameObject.SetActive(true);
    }

    public void OpenInventoryUI()
    {
        statusButton.gameObject.SetActive(false);
        inventoryButton.gameObject.SetActive(false);
        UIManager.Instance.Inventory.gameObject.SetActive(true);
    }

    
}
