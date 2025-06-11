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

    // 캐릭터의 스탯을 출력
    public void SetCharacterStatus(Character character)
    {
        attText.text = character.Att.ToString();
        defText.text = character.Def.ToString();
        hpText.text = character.HP.ToString();
    }

    public void GoMainMenu()
    {
        gameObject.SetActive(false);
        UIManager.Instance.MainMenu.statusButton.gameObject.SetActive(true);
        UIManager.Instance.MainMenu.inventoryButton.gameObject.SetActive(true);
    }
}
