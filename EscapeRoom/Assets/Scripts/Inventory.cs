using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject hotbar;
    public Item empty;
    public List<Item> items = new List<Item>();
    public int equippedSlot = 0;
    public GameObject openDoor;
    public GameObject NumberPad1;
    public GameObject NumberPad2;
    public GameObject TextInput;
    
    private void Start() {
        for(int i = 0; i <= 8; i++){
            items.Add(empty);
        }
        for(int i = 0; i <= 8; i++){
            hotbar.transform.GetChild(i).GetComponent<Image>().color = new Color (1f, 1f, 1f, 1f);;
        }
        hotbar.transform.GetChild(0).GetComponent<Image>().color = new Color (0f, 1f, 1f, 1f);
    }
    
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
    }

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

    public void Add(Item item){
        for(int i = 0; i <= 8; i++){
            if(items[i] == empty){
                items[i] = item;
                break;
            }
        }
        refreshHotbar();
    }
    public bool Interact(Item item, Transform transform){
        if(item.name == "PressurePlate1" && items[equippedSlot].name == "Stapler"){
            items[equippedSlot] = empty;
            refreshHotbar();
            transform.GetChild(0).gameObject.SetActive(true);
            return false;
        }
        if(item.name == "PressurePlate2" && items[equippedSlot].name == "Mug"){
            items[equippedSlot] = empty;
            refreshHotbar();
            transform.GetChild(0).gameObject.SetActive(true);
            return false;
        }
        if(item.name == "PressurePlate3" && items[equippedSlot].name == "BowTie"){
            items[equippedSlot] = empty;
            refreshHotbar();
            transform.GetChild(0).gameObject.SetActive(true);
            return false;
        }
        if(item.name == "Door" && items[equippedSlot].name == "Key"){
            items[equippedSlot] = empty;
            refreshHotbar();
            openDoor.SetActive(true);
            return true;
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
        return false;
    }

}
