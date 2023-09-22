using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatusTxt : MonoBehaviour
{
    [SerializeField]
    TMP_Text attackValue;
    [SerializeField]
    TMP_Text defendValue;
    [SerializeField]
    TMP_Text healthValue;
    [SerializeField]
    TMP_Text criticalValue;

    private void Start()
    {
        init();
    }

    public void init()
    {
        Debug.Log(PlayerManager.Get().CurrentCharacter.statSO.attack.ToString());
        attackValue.text = PlayerManager.Get().CurrentCharacter.statSO.attack.ToString();
        defendValue.text = PlayerManager.Get().CurrentCharacter.statSO.armor.ToString();
        healthValue.text = PlayerManager.Get().CurrentCharacter.statSO.health.ToString();
        criticalValue.text = PlayerManager.Get().CurrentCharacter.statSO.critical.ToString();
    }

}
