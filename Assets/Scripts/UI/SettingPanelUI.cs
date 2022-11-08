using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;


public class SettingPanelUI : MonoBehaviour
{
    [SerializeField] private Image settingpanel;
    [SerializeField] private Image backpanel;

    private bool settingpanelon = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            StartCoroutine(SettingPanel());
            
        }
    }
    
    IEnumerator SettingPanel()
    {
        if (!settingpanelon)
        {
            backpanel.gameObject.SetActive(true);
            yield return new WaitForSeconds(0.3f);
            settingpanel.rectTransform.DOMoveX(-6.5f, 0.5f).SetEase(Ease.OutCubic);
            settingpanelon = true;
        }
        else
        {
            backpanel.gameObject.SetActive(false);
            settingpanel.rectTransform.DOMoveX(-12.0f, 0.5f).SetEase(Ease.OutCubic);
            settingpanelon = false;
        }
    }
}
