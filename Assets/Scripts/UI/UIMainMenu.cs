using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    public Button statusButton;
    public Button inventoryButton;

    public TextMeshProUGUI jobText;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI levelText;



    public void SetCharacterInfo(Character character)
    {
        jobText.text = character.Job;
        nameText.text = character.NickName;
        levelText.text = $"Lv. {character.Level}";
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
