using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteract : Interactable
{
    //subprogram used in other scripts to declare an object as interactable
    public Item item;
    public void Interact(){
        Debug.Log("Interacting with " + item.name);
        if(FindObjectOfType<Inventory>().Interact(item, transform) == true){
            Destroy(gameObject);
        }
    }
}
