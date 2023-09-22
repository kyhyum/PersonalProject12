using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public ItemSlotUI[] uiSlots;
    public ItemSO[] slots;
    public ItemSO[] items;
    private ItemDescriptionPopup itemDescriptionPopup;
    public GameObject descriptionPopupObj;
    public static Inventory instance;
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        slots = new ItemSO[uiSlots.Length];

        for(int i = 0; i < slots.Length; i++)
        {
            slots[i] = ScriptableObject.CreateInstance<ItemSO>();
            uiSlots[i].index = i;
            uiSlots[i].Clear();
        }
        for(int i = 0; i < items.Length; i++)
        {
            uiSlots[i].Set(items[i]);
            slots[i] = items[i];
        }
    }

    public void SelectItem(int index)
    {
        if (slots[index] == null)
        {
            Debug.Log("null!!");
            return;
        }
        else
        {
            Debug.Log("Not null!!");
            descriptionPopupObj.SetActive(true);
            if(itemDescriptionPopup == null)
            {
                itemDescriptionPopup = descriptionPopupObj.GetComponent<ItemDescriptionPopup>();
            }
            itemDescriptionPopup.Init(slots[index]);
        }
    }

    public void openInventory()
    {
        this.gameObject.SetActive(true);
    }
    public void closeInventory()
    {
        this.gameObject.SetActive(false);
    }
}
