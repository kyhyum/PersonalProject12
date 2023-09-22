using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Character
{
    public string name;
    public string description;
    public int level;
    public string title;
    public int maxExp;
    public int exp;
    public int money;

    public StatSO statSO;
}
