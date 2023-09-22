using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlotUI : MonoBehaviour
{
    public Button button;
    public Image icon;

    public int index;
    public bool equipped;

    public void Set(ItemSO slot)
    {
        icon.gameObject.SetActive(true);
        icon.sprite = slot.icon;
    }

    public void Clear()
    {
        icon.gameObject.SetActive(false);
    }

    public void OnButtonClick()
    {
        Inventory.instance.SelectItem(index);
    }
}