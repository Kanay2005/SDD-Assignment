using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : Interactable
{
    public Item item;
    public void Interact()
    {
        
    }

    public void PickUp(){
        Debug.Log("Picking up " + item.name);
        FindObjectOfType<Inventory>().Add(item);
        Destroy(gameObject);
    }
}
