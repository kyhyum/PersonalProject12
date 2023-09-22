using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemDescriptionPopup : MonoBehaviour
{
    public Image itemImage;
    public TextMeshProUGUI itemName;
    public TextMeshProUGUI itemDescription;
    public TextMeshProUGUI itemEffect;
    public TextMeshProUGUI ConfirmBtnTxt;

    ItemSO itemSo;
    public void Awake()
    {
        this.gameObject.SetActive(false);
    }

    public void Init(ItemSO item)
    {
        if (item.isEquiped)
        {
            ConfirmBtnTxt.text = "해제";
        }
        else
        {
            ConfirmBtnTxt.text = "장착";
        }
        itemSo = item;
        itemImage.sprite = item.icon;
        itemName.text = item.name;
        itemDescription.text = item.description;
        if(item.effect == ItemEffect.Attack)
        {
            itemEffect.text = "공격력 +";
        }
        else
        {
            itemEffect.text = "방어력 +";
        }
        itemEffect.text += item.plusValue;
    }

    public void CancelBtn()
    {
        this.gameObject.SetActive(false);
    }
    
    public void ConfirmBtn()
    {
        if (itemSo.isEquiped)
        {
            if (itemSo.effect == ItemEffect.Attack)
            {
                PlayerManager.Get().CurrentCharacter.statSO.armor -= itemSo.plusValue;
            }
            else
            {
                PlayerManager.Get().CurrentCharacter.statSO.attack -= itemSo.plusValue;
            }
        }
        else
        {
            if (itemSo.effect == ItemEffect.Armor)
            {
                PlayerManager.Get().CurrentCharacter.statSO.armor += itemSo.plusValue;
                Debug.Log(PlayerManager.Get().CurrentCharacter);
            }
            else
            {
                Debug.Log(PlayerManager.Get().CurrentCharacter);
                PlayerManager.Get().CurrentCharacter.statSO.attack += itemSo.plusValue;
            }
        }
        this.gameObject.SetActive(false);
    }


}
