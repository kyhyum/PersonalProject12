using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager _singleton = new UIManager();
    public static UIManager Get() { return _singleton; }
    public static bool Has() { return _singleton != null; }
    [SerializeField]
    private Canvas CanvasTrs;
    private List<UIPopup> popups = new List<UIPopup>();

    public UIPopup ShowPopup(string popupname)
    {
        var obj = Resources.Load("Popups/" + popupname, typeof(GameObject)) as GameObject;
        if (!obj)
        {
            Debug.LogWarning("Failed to ShowPopup");
            return null;
        }
        return ShowPopupWithPrefab(obj, popupname);
    }

    public T ShowPopup<T>() where T : UIPopup
    {
        return ShowPopup(typeof(T).Name) as T;
    }

    public UIPopup ShowPopupWithPrefab(GameObject prefab, string popupName)
    {
        var obj = Instantiate(prefab);
        return ShowPopup(obj, popupName);
    }

    public UIPopup ShowPopup(GameObject obj, string popupname)
    {
        CanvasTrs = GameObject.Find("Canvas").GetComponent<Canvas>();
        var popup = obj.GetComponent<UIPopup>();
        popups.Insert(0, popup);
        if(CanvasTrs == null)
        {
            Debug.Log("Canvas not Initialized");
            return null;
        }
        obj.transform.SetParent(CanvasTrs.transform, false);
        obj.SetActive(true);
        return popup;
    }

    //TODO: ClosePopup 코드 짜야됌 시간이 없다..
}
