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
    public int itemType;        // enum클래스로 아이템 타입 관리
    public int itemEffect;      // enum클래스로 아이템 효과 관리
}
