using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatusPopup : MonoBehaviour
{
    public TextMeshProUGUI attackValue;
    public TextMeshProUGUI armorValue;
    public TextMeshProUGUI healthValue;
    public TextMeshProUGUI criticalValue;
    // Start is called before the first frame update
    private void Start()
    {
        init();
    }
    public void init()
    {
        attackValue.text = PlayerManager.Get().CurrentCharacter.statSO.attack.ToString();
        armorValue.text = PlayerManager.Get().CurrentCharacter.statSO.armor.ToString();
        healthValue.text = PlayerManager.Get().CurrentCharacter.statSO.health.ToString();
        criticalValue.text = PlayerManager.Get().CurrentCharacter.statSO.critical.ToString();
    }
}
