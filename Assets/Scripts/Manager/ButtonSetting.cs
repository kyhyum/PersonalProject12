using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSetting : MonoBehaviour
{

    [SerializeField] string popupName;

    public void btnClick()
    {
        UIManager.Get().ShowPopup(popupName);
    }
}
