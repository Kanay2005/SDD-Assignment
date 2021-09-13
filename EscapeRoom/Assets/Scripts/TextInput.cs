using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextInput : MonoBehaviour
{
    public InputField textInput;
    public GameObject Door;
    public void ButtonPress(){
        if(textInput.text.ToLower() == "marvel"){
            textInput.text = "CORRECT!";
            Destroy(Door);
        }
        else{
            textInput.text = "WRONG!";
        }
    }
    public void CloseButton(){
        textInput.text = "";
        this.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
    }
}