using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Description
{
    public string descriptionName;
    public int index;
    public List<string> descriptionList;
}

[CreateAssetMenu(menuName = "SO/Character/Description")]
public class CharacterDescriptionSO : ScriptableObject
{
    public List<Description> Descriptions;
}