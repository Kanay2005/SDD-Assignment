using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetSensitivity : MonoBehaviour
{
    public Slider senseSlider;
    private void Start() {
        if(PlayerPrefs.GetFloat("senseSlider") != 0){
            senseSlider.value = PlayerPrefs.GetFloat("senseSlider");
        }
    }
    public void SetVolumeLevel(float sliderValue){
        PlayerPrefs.SetFloat("senseSlider", sliderValue);
        PlayerPrefs.SetFloat("mouseSensitivity", sliderValue * 400);
    }
}
