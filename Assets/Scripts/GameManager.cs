using System.Collections;
using System.Collections.Generic;
using Unity.Jobs;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject("GameManager").GetComponent<GameManager>();
            }
            return instance;
        }
    }
    
    
    [SerializeField] Character _character;
    public Character Character { get { return _character; } }
    
    
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        //하이라키창에서 캐릭터를 찾아 할당
        GameObject character = GameObject.Find("Character");
        _character = character.GetComponent<Character>();

        SetPlayerData();
    }
    private void Start()
    {
        //UI에 스탯 할당하여 출력
        UIManager.Instance.MainMenu.SetCharacterInfo(_character);
        UIManager.Instance.Status.SetCharacterStatus(_character);
    }

    // 초기 캐릭터 데이터 설정
    void SetPlayerData()
    {
        _character.Job = "Wizard";
        _character.NickName = "ZiZonMino";
        _character.Level = 1;

        _character.Att = 30;
        _character.Def = 10;
        _character.HP = 50;
    }

    // 아이템이 장착 되었을 때 캐릭터의 스탯 재설정 및 출력
    public void SetEquipItemStats(Item item)
    {
        if(item.isEquip == true)
        {
            _character.Att += item.attack;
            _character.Def += item.defend;
        }
        else
        {
            _character.Att -= item.attack;
            _character.Def -= item.defend;
        }

        UIManager.Instance.Status.SetCharacterStatus(_character);
    }


}
