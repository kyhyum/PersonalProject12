using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CanvasUI : MonoBehaviour
{
    public Slider expSlider;

    public TextMeshProUGUI levelValue;
    public TextMeshProUGUI expValue;
    public TextMeshProUGUI coinValue;
    public TextMeshProUGUI title;
    public TextMeshProUGUI jobDes;
    public TextMeshProUGUI name;

    // Start is called before the first frame update
    void Start()
    {
        levelValue.text = PlayerManager.Get().CurrentCharacter.level.ToString();
        expValue.text = PlayerManager.Get().CurrentCharacter.exp.ToString() + " / " + PlayerManager.Get().CurrentCharacter.maxExp.ToString();
        coinValue.text = PlayerManager.Get().CurrentCharacter.money.ToString();
        title.text = PlayerManager.Get().CurrentCharacter.title;
        jobDes.text = PlayerManager.Get().CurrentCharacter.description;
        name.text = PlayerManager.Get().CurrentCharacter.name;

        expSlider.value = PlayerManager.Get().CurrentCharacter.exp;

    }

}
