using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))] //Image�� ������ ����� �� ���� 
public class CustomButton : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Image>().alphaHitTestMinimumThreshold = 0.1f;
    }
}