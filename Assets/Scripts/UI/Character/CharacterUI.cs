using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class CharacterUI : MonoBehaviour
{
    public Dictionary<string, Character> characterDictionary = new Dictionary<string, Character>();
    public List<CharacterSO> characterSO;

    [SerializeField]
    private GameObject characterPanel = null;
    [SerializeField]
    private CharacterDescriptionSO characterDescription = null;

    private TMP_Text characterNameText = null;
    private TMP_Text characterInfoText = null;
    private TMP_Text descriptionText = null;

    private Slider[] statSliders = null;

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        // 미리 데이터가 들어간 그게 있겟죠? 그걸 characterDictionary에 넣어줍시다 


        statSliders = characterPanel.GetComponentsInChildren<Slider>();
        TMP_Text[] characterTexts = characterPanel.GetComponentsInChildren<TMP_Text>();
        foreach(CharacterSO character in characterSO)
        {
            characterDictionary.Add(character.character.CharacterName, character.character);
        }

        characterNameText = characterTexts[0];
        characterInfoText = characterTexts[1];
        descriptionText = characterTexts[2];
    }

    public void SetCharacterUI(string idx)
    {
        //characterDictionary[idx].CharacterStatus
        Character character = characterDictionary[idx];
        SetCharacterText(character);
        SetCharacterSlider(character);
    }

    private void SetCharacterText(Character character)
    {
        characterNameText.text = character.CharacterName;
        characterInfoText.text = character.CharacterInfo;
        SetDescriptionOfCharacter(character);
    }
    private void SetCharacterSlider(Character character)
    {
        statSliders[0].value = character.CharacterStatus.power;
        statSliders[1].value = character.CharacterStatus.luck;
        statSliders[2].value = character.CharacterStatus.intelligence;
        statSliders[3].value = character.CharacterStatus.charisma;
        statSliders[4].value = character.CharacterStatus.speed;
    }
    private void SetDescriptionOfCharacter(Character character)
    {
        descriptionText.text = "";
        descriptionText.text += characterDescription.Descriptions[0].descriptionList[character.PainScale] + Environment.NewLine;
        descriptionText.text += characterDescription.Descriptions[1].descriptionList[character.InsaneScale] + Environment.NewLine;
        descriptionText.text = descriptionText.text.Replace("#", character.CharacterName);
    }
}