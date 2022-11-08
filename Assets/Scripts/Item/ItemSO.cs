using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "SO/Item")]
public class ItemSO : ScriptableObject
{
    public string itemName;
    public string itemDiscription;
    public Image itemImage;
    public int itemType;        // enumŬ������ ������ Ÿ�� ����
    public int itemEffect;      // enumŬ������ ������ ȿ�� ����
}
