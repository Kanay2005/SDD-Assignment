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

    public void Add(Item item){
        for(int i = 0; i <= 8; i++){
            if(items[i] == empty){
                items[i] = item;
                break;
            }
        }
        for(int i = 0; i <= items.Count-1; i++){
            Image image = hotbar.transform.GetChild(i).GetChild(0).gameObject.GetComponent<Image>();
            if(items[i] != empty){
                image.sprite = items[i].icon;
                image.color = new Color(image.color.r, image.color.g, image.color.b, 1f);
            }
        }
    }
    public void Interact(Item item){
        
        items.Remove(item);
        for(int i = 0; i <= items.Count-1; i++){
            Image image = hotbar.transform.GetChild(i).GetChild(0).gameObject.GetComponent<Image>();
            image.sprite = items[i].icon;
            image.color = new Color(image.color.r, image.color.g, image.color.b, 1f);
        }
    }

}
