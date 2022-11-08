using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryUI : MonoBehaviour
{
    public Transform textTransform;
    public TextScript textPrefab;

    public void WriteDiary(string content, string itemType = null, int variation = 0)
    {
        TextScript obj = Instantiate(textPrefab, textTransform);
        if (itemType == null && variation != 0)
        {
            string sign;
            if (variation < 0)
            {
                sign = "-";
            }
            else
            {
                sign = "+";
            }
            obj.SetText(content, itemType + " " + sign + variation.ToString());
        }
        else
        {
            obj.SetText(content);
        }
    }

    public void ResetDiary()
    {
        TextScript[] child = GetComponentsInChildren<TextScript>();
        foreach (TextScript item in child)
        {
            Destroy(item.gameObject);
        }
    }
}
