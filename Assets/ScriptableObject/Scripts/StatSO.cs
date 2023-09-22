using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StatData", menuName = "Players/Stats", order = 0)]
public class StatSO : ScriptableObject
{
    [Header("Stat Info")]
    public int attack;
    public int armor;
    public int health;
    public int critical;

}
