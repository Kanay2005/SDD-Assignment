using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class OnLoad : MonoBehaviour
{
    public AudioMixer mixer;
    void Update(){
        if(PlayerPrefs.GetFloat("volumeSlider") != 0){
            Debug.Log(PlayerPrefs.GetFloat("volumeSlider"));
            mixer.SetFloat("MusicVolume", (Mathf.Log10(PlayerPrefs.GetFloat("volumeSlider")) * 20));
        }

        if(PlayerPrefs.GetFloat("senseSlider") != 0){
            PlayerPrefs.SetFloat("mouseSensitivity", PlayerPrefs.GetFloat("senseSlider") * 400);
        }
    }

}
