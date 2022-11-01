using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Item : MonoBehaviour
{
    public Data item;

    [ContextMenu("To Json Data")]
    void SaveItemDataToJson()
    {
        string jsonData = JsonUtility.ToJson(item);
        string path = Path.Combine(Application.dataPath, "/Itemdata.json");
        File.WriteAllText(path, jsonData);
    }
}

[System.Serializable]
public class Data
{
    public string potion_name;
    public int value;
    public List<Character> character = new List<Character>();
}




