using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class Character : MonoBehaviour
{

    private string job;
    private string nickName;
    private int level;
    private int att;
    private int def;
    private int hp;

    public string Job 
    {
        get { return job; }

        set
        {
            if(value == "Wizard" || value == "Warrior" || value == "Archer")
            {
                 job = value;
            }
            else
            {
                job = "Warrior";
            }
        }
    }

    public string NickName { get { return nickName; } set { nickName = value; } }

    public int Level 
    {
        get { return level; } 
        
        set
        {
            if(value <= 0)
            {
                level = 1;
            }
            else
            {
                level = value;
            }
        }
    }

    public int Att
    {
        get { return att; }

        set
        {
            if (value < 0)
            {
                att = 0;
            }
            else
            {
                att = value;
            }
        }
    }

    public int Def
    {
        get { return def; }

        set
        {
            if (value < 0)
            {
                def = 0;
            }
            else
            {
                def = value;
            }
        }
    }

    public int HP
    {
        get { return hp; }

        set
        {
            if (value < 0)
            {
                hp = 0;
            }
            else
            {
                hp = value;
            }
        }
    }
}
