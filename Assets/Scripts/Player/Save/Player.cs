﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region Key Variables for the player
    // health, level, exp, mana, stamina, position, name, customisation
    public int level;
    public string playerName;
    public float maxHealth, curHealth;
    public float x, y, z;
    public HealthBar health;
    public CheckPoint checkPoint;
    #endregion

    public void SaveFunction()
    {
        maxHealth = health.maxHealth;
        curHealth = health.curHealth;
        x = checkPoint.curCheckPoint.position.x;
        y = checkPoint.curCheckPoint.position.y;
        z = checkPoint.curCheckPoint.position.z;
        Save.SaveData(this);
    }

    public void LoadData()
    {
        Data data = Save.LoadData();
        level = data.level;
        name = data.playerName;
        maxHealth = data.maxHealth;
        curHealth = data.curHealth;
        health.maxHealth = maxHealth;
        health.curHealth = curHealth;
        x = data.x;
        y = data.y;
        z = data.z;
        this.transform.position = new Vector3(x, y, z);
    }

    private void Awake()
    {
        if (Input.GetKeyDown(KeyCode.F11))
        {
            LoadData();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F12))
        {
            SaveFunction();
        }
    }
}
