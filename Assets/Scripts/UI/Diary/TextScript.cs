using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextScript : MonoBehaviour
{
    private TextMeshProUGUI eventText;
    private TextMeshProUGUI resultText;

    public void SetText(string eventText, string resultText = null)
    {
        this.eventText.text = eventText;
        this.resultText.text = resultText;
    }
}
