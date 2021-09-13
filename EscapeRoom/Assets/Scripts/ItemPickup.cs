using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : Interactable
{
    //script that allows for an item to be picked up
    public Item item;

    public void PickUp(){
        Debug.Log("Picking up " + item.name);
        FindObjectOfType<Inventory>().Add(item);
        Destroy(gameObject);
    }
}
