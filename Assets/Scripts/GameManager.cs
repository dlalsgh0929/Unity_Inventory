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

        //���̶�Űâ���� ĳ���͸� ã�� �Ҵ�
        GameObject character = GameObject.Find("Character");
        _character = character.GetComponent<Character>();

        SetPlayerData();
    }
    private void Start()
    {
        //UI�� ���� �Ҵ��Ͽ� ���
        UIManager.Instance.MainMenu.SetCharacterInfo(_character);
        UIManager.Instance.Status.SetCharacterStatus(_character);
    }

    // �ʱ� ĳ���� ������ ����
    void SetPlayerData()
    {
        _character.Job = "Wizard";
        _character.NickName = "ZiZonMino";
        _character.Level = 1;

        _character.Att = 30;
        _character.Def = 10;
        _character.HP = 50;
    }

    // �������� ���� �Ǿ��� �� ĳ������ ���� �缳�� �� ���
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
