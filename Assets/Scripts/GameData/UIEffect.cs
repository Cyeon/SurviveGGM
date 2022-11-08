using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIEffect: MonoBehaviour
{
    [SerializeField]
    private Image[] image;

    private float alpha = 0;

    private int findcharacternum = 0;

    private void Start()
    {
        image = GetComponentsInChildren<Image>();
    }

    IEnumerator CharacterUP()
    {
        alpha = 0;
        Color color = image[characternum()].color;

        while (alpha <= 1)
        {
            alpha += 0.0001f;
            yield return new WaitForSeconds(0.001f);
            color.a += alpha;
            image[characternum()].color = color;

        }
    }

    int characternum()
    {   
        if (findcharacternum == 0)
        {
            return 0;
        }
        else
        {
            return -1;
        }
    }

    
}
