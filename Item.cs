using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Scripts/Inventory/Items")]
public class Item : ScriptableObject
{
    public string itemName = "New Item";
    public string itemDescription = "New Description";
    public Sprite icon;
    public enum Type { Default, Consumable, Parts, Health}
    public Type type = Type.Default;
    

}
