using System.Collections;
using System.Collections.Generic;
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

        GameObject character = GameObject.Find("Character");

        _character = character.GetComponent<Character>();
    }



    


}
