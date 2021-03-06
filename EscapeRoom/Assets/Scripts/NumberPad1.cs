using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NumberPad1 : MonoBehaviour
{
    //the different subroutines are used to input different numbers by the press of different buttons on the number pad
    public TextMeshProUGUI outputText;
    public GameObject closedDoor;
    public GameObject openDoor;
    string text;
    private void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)){
            CloseButton();
        }
    }
    
    private void Start() {
        text = outputText.text;
    }
    void ButtonPressed(string input){
        if(text.Length < 4){
            text += input;
        }
        outputText.text = text;
    }
    public void OneButton(){
        ButtonPressed("1");
    }
    public void TwoButton(){
        ButtonPressed("2");
    }
    public void ThreeButton(){
        ButtonPressed("3");
    }
    public void FourButton(){
        ButtonPressed("4");
    }
    public void FiveButton(){
        ButtonPressed("5");
    }
    public void SixButton(){
        ButtonPressed("6");
    }
    public void SevenButton(){
        ButtonPressed("7");
    }
    public void EightButton(){
        ButtonPressed("8");
    }
    public void NineButton(){
        ButtonPressed("9");
    }
    public void ZeroButton(){
        ButtonPressed("0");
    }
    public void ACButton(){
        outputText.text = "";
        text = "";
        outputText.characterSpacing = 25;
        outputText.fontSize = 150;
        outputText.color = Color.white;
    }
    public void EnterButton(){
        if(text == "3029"){
            outputText.text = "CORRECT";
            outputText.color = Color.green;
            outputText.characterSpacing = 0;
            outputText.fontSize = 100;
            closedDoor.SetActive(false);
            openDoor.SetActive(true);
        }
        else{
            outputText.text = "WRONG!";
            outputText.color = Color.red;
            outputText.characterSpacing = 0;
            outputText.fontSize = 100;
        }
    }
    public void CloseButton(){
        outputText.characterSpacing = 25;
        outputText.fontSize = 150;
        outputText.color = Color.white;
        outputText.text = "";
        text = "";
        this.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
    }

}
