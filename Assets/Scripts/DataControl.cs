using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DataControl : MonoBehaviour
{
    public Slider Fslider;
    public Slider Wslider;


    [SerializeField]
    private TextMeshProUGUI FstatText;
    [SerializeField]
    private TextMeshProUGUI WstatText;


    private void Update()
    {
        CheckText();
    }

    public void CheckText()
    {
        int F = (int)Fslider.value;
        int W = (int)Wslider.value;

        FstatText.text = string.Format("{0}",F);
        WstatText.text = string.Format("{0}",W);
    }



}
