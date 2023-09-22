using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private static PlayerManager _singleton;
    public static PlayerManager Get() { return _singleton; }
    public static bool Has() { return _singleton != null; }

    [SerializeField]  private Character baseCharacter;
    public Character CurrentCharacter;
    void Awake()
    {
        if (_singleton == null)
        {
            _singleton = this;
        }
        UpdateCharacterStats();
    }


    private void UpdateCharacterStats()
    {
        StatSO statSO = null;
        if (baseCharacter != null)
        {
            statSO = Instantiate(baseCharacter.statSO);
        }

        CurrentCharacter = new Character { statSO = statSO };
        CurrentCharacter.name = baseCharacter.name;
        CurrentCharacter.title = baseCharacter.title;
        CurrentCharacter.money = baseCharacter.money;
        CurrentCharacter.level = baseCharacter.level;
        CurrentCharacter.description = baseCharacter.description;

        CurrentCharacter.maxExp = baseCharacter.maxExp;
        CurrentCharacter.exp = baseCharacter.exp;
    }
}
