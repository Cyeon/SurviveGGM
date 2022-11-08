using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JsonData : MonoBehaviour
{
    public GameData gamedata;

    [ContextMenu("To Json Data")]
    void SaveGameDataToJson()
    {
        string jsonData = JsonUtility.ToJson(gamedata,true);
        jsonData = Crypto.AESEncrypt128(jsonData);
        string path = Path.Combine(Application.dataPath, "GameData.json");
        File.WriteAllText(path, jsonData);
    }

    [ContextMenu("From Json Data")]
    void LoadGameDataFromJson()
    {
        string path = Path.Combine(Application.dataPath, "GameData.json");
        string jsonData =  File.ReadAllText(path);
        jsonData = Crypto.AESDecrypt128(jsonData);
        gamedata = JsonUtility.FromJson<GameData>(jsonData);
    }
}

[System.Serializable]
public class GameData
{
    public int FirstaidAmount = 0;
    public int MentalcareAmount = 0;
    public int MineralwaterAmount = 0;

    public List<WeaponData> weaponDatas = new List<WeaponData>();
    public List<FoodData> foodDatas = new List<FoodData>();
    public List<Character> characterDatas = new List<Character>();
}

[System.Serializable]
public class FoodData
{
    public string FoodName;
    public int Foodamount;
}

[System.Serializable]
public class WeaponData
{
    public string WeaponName;
    public int WeaponAmount;
}



