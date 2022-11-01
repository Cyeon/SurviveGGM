using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Character
{
    private string name = "";
    private int id = -1;
    private string in4mation = "";

    [SerializeField]
    private Stat status;

    private int curHealth = 0;
    private int curMental = 0;

    #region Property
    public string CharacterName => name;
    public int CharacterID => id;
    public string CharacterInfo => in4mation;
    public Stat CharacterStatus => status;
    /// <summary>
    /// 부상의 심각도 
    /// 0 -> 5 심각 
    /// </summary>
    public int PainScale
    {
        get
        {
            //세부 수치에 따라 수정할 예정
            if (curHealth >= 100)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }

    /// <summary>
    /// 멘탈 붕괴 정도 
    /// </summary>
    public int InsaneScale
    {
        get
        {
            if (curMental >= 100)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
    #endregion
}