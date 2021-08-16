using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteract : Interactable
{
    public Item item;
    public void Interact(){
        Debug.Log("Interacting with " + item.name);
        if(FindObjectOfType<Inventory>().Interact(item, transform) == true){
            Destroy(gameObject);
        }
    }
}
