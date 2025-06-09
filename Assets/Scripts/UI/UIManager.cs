using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;
    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameObject("UIManager").AddComponent<UIManager>();
            }
            return _instance;
        }
    }

    [SerializeField] UIMainMenu _mainMenu;
    [SerializeField] UIStatus _status;
    [SerializeField] UIInventory _inventory;

    public UIMainMenu MainMenu { get { return _mainMenu; } }
    public UIStatus Status { get { return _status; } }
    public UIInventory Inventory { get { return _inventory; } }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (_instance == this)
            {
                Destroy(gameObject);
            }
        }

        _mainMenu = GetComponentInChildren<UIMainMenu>(true); //비활설화된 오브젝트도 탐색가능
        _status = GetComponentInChildren<UIStatus>(true);
        _inventory = GetComponentInChildren<UIInventory>(true);

    }

    
    private void Start()
    {
        _mainMenu.SetCharacterInfo();
        _status.SetCharacterStatus();
    }

    
    void Update()
    {
        
    }

    
}
