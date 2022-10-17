using UnityEngine;
using UnityEngine.UI;

public enum ItemType
{
    Food,
    Water,
    Weapon,
    Common,
    FirstAid,
    MentalCare
}

public class Item
{
    [SerializeField]
    private int id = -1;
    [SerializeField]
    private string name = "";
    [SerializeField]
    private int weight = 0;
    [SerializeField]
    private Image iconImage = null;
    [SerializeField]
    private string description = "";
    [SerializeField]
    private float lootPercent = 10f;

    #region Property
    public int ID
    {
        get
        {
            return id;
        }
    }

    public string Name
    {
        get
        {
            return name;
        }
    }
    public int Weight
    {
        get
        {
            return weight;
        }
    }
    public Image IconImage
    {
        get
        {
            return iconImage;
        }
    }
    public string Description
    {
        get
        {
            return description;
        }
    }
    public float LootPercent
    {
        get
        {
            return lootPercent;
        }
    }
    #endregion




}