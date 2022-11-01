using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Character
{
    private string name = "";
    private int id = -1;
    private string information = "";

    [SerializeField]
    private Stat status;

    private int curHealth = 0;
    private int curMental = 0;

    #region Property
    public string CharacterName => name;
    public int CharacterID => id;
    public string CharacterInfo => information;
    public Stat CharacterStatus => status;
    /// <summary>
    /// �λ��� �ɰ��� 
    /// 0 -> 5 �ɰ� 
    /// </summary>
    public int PainScale
    {
        get
        {
            //���� ��ġ�� ���� ������ ����
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
    /// ��Ż �ر� ���� 
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