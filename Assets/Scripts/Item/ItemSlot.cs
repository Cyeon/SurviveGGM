using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemSlot : MonoBehaviour
{
    public ItemSO item;

    [SerializeField]
    private TextMeshProUGUI itemName = null;
    [SerializeField]
    private TextMeshProUGUI itemDiscription = null;
    [SerializeField]
    private Image itemImage = null;

    public void SetValue(ItemSO item)
    {
        this.item = item;
        UpdateValue();
    }

    public void UpdateValue()
    {
        itemName.text = item.itemName.ToString();
        itemDiscription.text = itemDiscription.ToString();
        itemImage = item.itemImage;
    }

}
