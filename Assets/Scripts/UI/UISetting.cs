using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class UIObject
{
    public string name;
    public GameObject gameobj;
}

public class UISetting : MonoBehaviour
{
    [SerializeField]
    [Header("SettingChang")]
    private GameObject settingChange = null;

    [Space(20)]
    [Header("UI_Objects")]
    [SerializeField] private List<UIObject> objects = new List<UIObject>();


    [Header("Object Animation Time")]
    [SerializeField] private float objAnimtime = 1f;


    private GameObject activeObject = null;
    private bool isSettingOn = false;


    private void Start()
    {
        activeObject = objects[0].gameobj;
        activeObject.SetActive(true);
    }

    public void OnClickBtn(int _idx)
    {
        CloseOtherObjects();

        if (activeObject != null)
        {
            CloseOtherObjects();
        }

        activeObject = objects[_idx].gameobj;
        activeObject.SetActive(true);
    }

    private void CloseOtherObjects()
    {
        if (activeObject == null) return;

        activeObject.SetActive(false);
        activeObject = null;
    }

    public void OnCloseORActiveChang()
    {
        if (isSettingOn)
        {
            settingChange.SetActive(false);
        }
        else
        {
            settingChange.SetActive(true);
        }

        isSettingOn = !isSettingOn;

    }
}
