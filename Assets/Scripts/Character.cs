using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public string job;
    public string name;
    public int level;
    public int Att;
    public int Def;
    public int HP;


    void Start()
    {
        job = "Wizard";
        name = "ZiZonMino";
        level = 1;

        Att = 30;
        Def = 10;
        HP = 50;
    }

    void Update()
    {
        
    }
}
