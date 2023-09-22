using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPopup : MonoBehaviour
{
    public void Show()
    {
        gameObject.SetActive(true);
        // 팝업이 나타날 때 수행할 작업을 여기에 추가합니다.
    }

    public void Close()
    {
        gameObject.SetActive(false);
        // 팝업을 닫을 때 수행할 작업을 여기에 추가합니다.
    }

}