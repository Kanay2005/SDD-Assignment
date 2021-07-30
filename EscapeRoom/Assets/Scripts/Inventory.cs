using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject hotbar;
    public List<Item> items = new List<Item>();
    public void Add(Item item){
        items.Add(item);
        for(int i = 0; i <= items.Count-1; i++){
            Image image = hotbar.transform.GetChild(i).GetChild(0).gameObject.GetComponent<Image>();
            image.sprite = item.icon;
            image.color = new Color(image.color.r, image.color.g, image.color.b, 1f);
        }
    }
    public void Remove(Item item){
        
    }

}
