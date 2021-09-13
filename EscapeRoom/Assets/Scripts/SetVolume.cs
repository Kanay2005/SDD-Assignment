using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    //sets the music volume of the game when loading into the game
    public Slider volumeSlider;
    public AudioMixer mixer;
    private void Start() {
        if(PlayerPrefs.GetFloat("volumeSlider") != 0){
            volumeSlider.value = PlayerPrefs.GetFloat("volumeSlider");
        }
        
    }
    public void SetVolumeLevel(float sliderValue){
        PlayerPrefs.SetFloat("volumeSlider", sliderValue);
        mixer.SetFloat("MusicVolume",Mathf.Log10(sliderValue) * 20);
    }

}
