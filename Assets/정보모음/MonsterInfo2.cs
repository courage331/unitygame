﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//검정 슬라임

public class MonsterInfo2 : MonoBehaviour
{
    GameObject monster;

    public static MonsterInfo2 instance;

    public int monsterhp = 1;

    

    void Start()
    {
        this.monster = GameObject.Find("monster");

        MonsterInfo2.instance = this;
    }

    public int Monhp()
    {
        
            return monsterhp;
        
    }
    


    // Update is called once per frame
    void Update()
    {

    }
}
