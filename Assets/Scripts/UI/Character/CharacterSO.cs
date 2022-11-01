using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName =("SO/Character/Character"))]
public class CharacterSO : ScriptableObject
{
    public Character character;
    private void Awake()
    {
        character.CurMental = character.CharacterStatus.mental;
        character.CurHealth = character.CharacterStatus.health;
    }
}
