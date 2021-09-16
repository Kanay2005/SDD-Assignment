using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    //variable declaration for the required variables
    public GameObject hotbar;
    public Item empty;
    public List<Item> items = new List<Item>();
    public int equippedSlot = 0;
    public GameObject openDoor;
    public GameObject NumberPad1;
    public GameObject NumberPad2;
    public GameObject TextInput;
    public GameObject HiddenDoor;
    public GameObject ButtonOne;
    public GameObject ButtonTwo;
    public GameObject ButtonThree;
    public GameObject ButtonFour;
    public GameObject ButtonFive;
    public GameObject ButtonSix;
    public GameObject ButtonSeven;
    public GameObject ButtonEight;
    public GameObject ButtonNine;
    bool buttonDone;
    public Transform lockedText;
    public GameObject renderCanvas;
    public GameObject closedLockerDoor;
    public GameObject openLockerDoor;
    bool staplerPlaced = false;
    bool MugPlaced = false;
    bool BowtiePlaced = false;
    public GameObject Hint;
    
    //sets up the hotbar to be empty
    private void Start() {
        for(int i = 0; i <= 8; i++){
            items.Add(empty);
        }
        for(int i = 0; i <= 8; i++){
            hotbar.transform.GetChild(i).GetComponent<Image>().color = new Color (1f, 1f, 1f, 1f);;
        }
        hotbar.transform.GetChild(0).GetComponent<Image>().color = new Color (0f, 1f, 1f, 1f);
    }
    
    //updates the hotbar with new changes every frame
    private void Update() {
        for(int x = 0; x <= 8; x++){
            if(Input.GetKeyDown((KeyCode)(49+x))){
                equippedSlot = x;
                for(int i = 0; i <= 8; i++){
                    hotbar.transform.GetChild(i).GetComponent<Image>().color = new Color (1f, 1f, 1f, 1f);
                }
                hotbar.transform.GetChild(x).GetComponent<Image>().color = new Color (0f, 1f, 1f, 1f);
            }
        }
        if(buttonDone == false && ButtonOne.GetComponent<Renderer>().material.color == Color.black && ButtonTwo.GetComponent<Renderer>().material.color == Color.black && ButtonThree.GetComponent<Renderer>().material.color == Color.black && ButtonFour.GetComponent<Renderer>().material.color == Color.white && ButtonFive.GetComponent<Renderer>().material.color == Color.white && ButtonSix.GetComponent<Renderer>().material.color == Color.black && ButtonSeven.GetComponent<Renderer>().material.color == Color.white && ButtonEight.GetComponent<Renderer>().material.color == Color.white && ButtonNine.GetComponent<Renderer>().material.color == Color.black){
            Destroy(ButtonTwo);
            buttonDone = true;
        }
        if(staplerPlaced && MugPlaced && BowtiePlaced){
            closedLockerDoor.SetActive(false);
            openLockerDoor.SetActive(true);
        }
    }

    //subroutine to refresh the images of the hotbar
    private void refreshHotbar(){
        for(int i = 0; i <= items.Count-1; i++){
            Image image = hotbar.transform.GetChild(i).GetChild(0).gameObject.GetComponent<Image>();
            if(items[i] != empty){
                image.sprite = items[i].icon;
                image.color = new Color(image.color.r, image.color.g, image.color.b, 1f);
            }
            else{
                image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
            }
        }
    }

    //subroutine to add new items to the hotbar
    public void Add(Item item){
        for(int i = 0; i <= 8; i++){
            if(items[i] == empty){
                items[i] = item;
                break;
            }
        }
        refreshHotbar();
    }

    //the different interactions for the items that can be clicked on
    public bool Interact(Item item, Transform transform){
        if(item.name == "PressurePlate1" && items[equippedSlot].name == "Stapler"){
            items[equippedSlot] = empty;
            refreshHotbar();
            transform.GetChild(0).gameObject.SetActive(true);
            staplerPlaced = true;
            return false;
        }
        if(item.name == "PressurePlate2" && items[equippedSlot].name == "Mug"){
            items[equippedSlot] = empty;
            refreshHotbar();
            transform.GetChild(0).gameObject.SetActive(true);
            MugPlaced = true;
            return false;
        }
        if(item.name == "PressurePlate3" && items[equippedSlot].name == "BowTie"){
            items[equippedSlot] = empty;
            refreshHotbar();
            transform.GetChild(0).gameObject.SetActive(true);
            BowtiePlaced = true;
            return false;
        }
        if(item.name == "NumberPad1"){
            NumberPad1.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
        }
        if(item.name == "NumberPad2"){
            NumberPad2.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
        }
        if(item.name == "TextInput"){
            TextInput.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
        }
        if(item.name == "HiddenButton"){
            Destroy(HiddenDoor);
        }
        if(item.name == "ButtonOne"){
            if(ButtonOne.GetComponent<Renderer>().material.color == Color.white){
                ButtonOne.GetComponent<Renderer>().material.color = Color.black;
            }
            else{
                ButtonOne.GetComponent<Renderer>().material.color = Color.white;
            }
        }
        if(item.name == "ButtonTwo"){
            if(ButtonTwo.GetComponent<Renderer>().material.color == Color.white){
                ButtonTwo.GetComponent<Renderer>().material.color = Color.black;
            }
            else{
                ButtonTwo.GetComponent<Renderer>().material.color = Color.white;
            }
        }
        if(item.name == "ButtonThree"){
            if(ButtonThree.GetComponent<Renderer>().material.color == Color.white){
                ButtonThree.GetComponent<Renderer>().material.color = Color.black;
            }
            else{
                ButtonThree.GetComponent<Renderer>().material.color = Color.white;
            }
        }
        if(item.name == "ButtonFour"){
            if(ButtonFour.GetComponent<Renderer>().material.color == Color.white){
                ButtonFour.GetComponent<Renderer>().material.color = Color.black;
            }
            else{
                ButtonFour.GetComponent<Renderer>().material.color = Color.white;
            }
        }
        if(item.name == "ButtonFive"){
            if(ButtonFive.GetComponent<Renderer>().material.color == Color.white){
                ButtonFive.GetComponent<Renderer>().material.color = Color.black;
            }
            else{
                ButtonFive.GetComponent<Renderer>().material.color = Color.white;
            }
        }
        if(item.name == "ButtonSix"){
            if(ButtonSix.GetComponent<Renderer>().material.color == Color.white){
                ButtonSix.GetComponent<Renderer>().material.color = Color.black;
            }
            else{
                ButtonSix.GetComponent<Renderer>().material.color = Color.white;
            }
        }
        if(item.name == "ButtonSeven"){
            if(ButtonSeven.GetComponent<Renderer>().material.color == Color.white){
                ButtonSeven.GetComponent<Renderer>().material.color = Color.black;
            }
            else{
                ButtonSeven.GetComponent<Renderer>().material.color = Color.white;
            }
        }
        if(item.name == "ButtonEight"){
            if(ButtonEight.GetComponent<Renderer>().material.color == Color.white){
                ButtonEight.GetComponent<Renderer>().material.color = Color.black;
            }
            else{
                ButtonEight.GetComponent<Renderer>().material.color = Color.white;
            }
        }
        if(item.name == "ButtonNine"){
            if(ButtonNine.GetComponent<Renderer>().material.color == Color.white){
                ButtonNine.GetComponent<Renderer>().material.color = Color.black;
            }
            else{
                ButtonNine.GetComponent<Renderer>().material.color = Color.white;
            }
        }
        if(item.name=="Cupboard"){
            if(items[equippedSlot].name == "Key"){
                items[equippedSlot] = empty;
                openDoor.SetActive(true);
                refreshHotbar();
                return(true);
            }
            else{
                Transform tempLockedText = Instantiate(lockedText);
                tempLockedText.transform.SetParent(renderCanvas.transform, false);
            }
        }
        
        if(item.name == "UnlockedDrawer"){
            return(true);
        }
        if(item.name == "LockedDrawer"){
            if(items[equippedSlot].name == "Key"){
                items[equippedSlot] = empty;
                refreshHotbar();
                return(true);
            }
            else{
                Transform tempLockedText = Instantiate(lockedText);
                tempLockedText.transform.SetParent(renderCanvas.transform, false);
            }
        }
        if(item.name == "Paper"){
            Hint.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
        }
        return false;
    }

}
