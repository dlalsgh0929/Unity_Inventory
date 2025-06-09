using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class UIStatus : MonoBehaviour
{
    public TextMeshProUGUI attText;
    public TextMeshProUGUI defText;
    public TextMeshProUGUI hpText;

    public void SetCharacterStatus()
    {
        attText.text = GameManager.Instance.Character.Att.ToString();
        defText.text = GameManager.Instance.Character.Def.ToString();
        hpText.text = GameManager.Instance.Character.HP.ToString();
    }

    public void GoMainMenu()
    {
        gameObject.SetActive(false);
        UIManager.Instance.MainMenu.statusButton.gameObject.SetActive(true);
        UIManager.Instance.MainMenu.inventoryButton.gameObject.SetActive(true);
    }
}
