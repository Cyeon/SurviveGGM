using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupUI : MonoBehaviour
{
    [SerializeField]
    private GameObject uiCanvas = null;
    [SerializeField]
    private GameObject characterPanel = null;
    public void PopupCharacter(CharacterSO character)
    {
        characterPanel.SetActive(true);
        uiCanvas.GetComponent<CharacterUI>().SetCharacterUI(character.character.CharacterName);
    }

    public void PopDownCharacter()
    {
        characterPanel.SetActive(false);
    }
}
