using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//allows for a fast way to create new items with set inputs 
[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = "New Item";
    public Sprite icon = null;

}
