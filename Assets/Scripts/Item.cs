using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Item : MonoBehaviour
{
    public ItemTypes item;
    
    
    [ContextMenu("To Json Data")]
    void SaveItemDataToJson()
    {
        string jsonData = JsonUtility.ToJson(item);
        string path = Path.Combine(Application.dataPath, "/Itemdata.json");
        File.WriteAllText(path, jsonData);
    }

    //[SerializeField]
    //private int id = -1;
    //[SerializeField]
    //private string name = "";
    //[SerializeField]
    //private int weight = 0;
    //[SerializeField]
    //private string description = "";
    //[SerializeField]
    //private float lootPercent = 10f;

    //public enum ItemType
    //{
    //      ID;
    //    Water,
    //    Weapon,
    //    Common,
    //    FirstAid,
    //    MentalCare
    //}

}

[System.Serializable]
public class ItemTypes
{
    public string[] foodtypes;
    public int water;
    public int[] ID;
    public string[] weapon;
    public string[] Common;
    public int FirstAid;
    public int mentalCare;
    public int DegreeOfInfectionLevel;
}