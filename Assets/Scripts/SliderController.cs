
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class SliderController : MonoBehaviour
{
    public Image soundimage;
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] Slider volumeSlider;
    [SerializeField] string parameterName = "";
    [SerializeField] Sprite[] sprites;
    private void Update()
    {
     
        if (volumeSlider.value == -14)
            soundimage.sprite = sprites[0];
        else if (-18 < volumeSlider.value && volumeSlider.value < -7)
            soundimage.sprite = sprites[1];
        else if (-5 <= volumeSlider.value && volumeSlider.value < 0)
            soundimage.sprite = sprites[2];
        else if (volumeSlider.value == 7)
            soundimage.sprite = sprites[3];


    }
    public void SoundControl()
    {
        float sound = volumeSlider.value;
        if (sound == -14) audioMixer.SetFloat(parameterName, -80);
        else audioMixer.SetFloat(parameterName, sound);
    }
}
