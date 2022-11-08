using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Character
{
    [SerializeField]
    private string name = "";
    [SerializeField]
    private int id = -1;
    [SerializeField]
    private string information = "";
    [SerializeField]
    private bool IsInfection = false;
    [SerializeField]
    private Stat status;

    [SerializeField]
    private int curHealth = 0;
    [SerializeField]
    private int curMental = 0;

    #region Property
    public int CurHealth { get => curHealth; set { curHealth = value; } }
    public int CurMental { get => curMental; set { curMental = value; } }
    public string CharacterName => name;
    public int CharacterID => id;
    public string CharacterInfo => information;
    public Stat CharacterStatus => status;
    /// <summary>
    /// ºÎ»óÀÇ ½É°¢µµ 
    /// 0 -> 5 ½É°¢ 
    /// </summary>
    public int PainScale
    {
        get
        {
            switch (curHealth)
            {
                case 5:
                    return 0;
                case 4:
                    return 1;
                case 3:
                    return 2;
                case 2:
                    return 3;
                case 1:
                    return 4;
                default:
                    return -1;
            }
        }
    }

    /// <summary>
    /// ¸àÅ» ºØ±« Á¤µµ 
    /// </summary>
    public int InsaneScale
    {
        get
        {
            switch (curMental)
            {
                case 5:
                    return 0;
                case 4:
                    return 1;
                case 3:
                    return 2;
                case 2:
                    return 3;
                case 1:
                    return 4;
                default:
                    return -1;
            }
        }
    }
    #endregion
}