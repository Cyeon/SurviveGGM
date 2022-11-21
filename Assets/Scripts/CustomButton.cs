using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))] //Image가 없으면 사용할 수 없음 
public class CustomButton : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Image>().alphaHitTestMinimumThreshold = 0.1f;
    }
}