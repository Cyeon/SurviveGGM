using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Character
{
    [SerializeField]
    private Stat status;

    public Stat CharacterStatus
    {
        get
        {
            return status;
        }
    }

    private int curHealth = 0;
    

}