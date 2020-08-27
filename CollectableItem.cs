using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Fungus;

[Serializable]
public class CollectableItem : MonoBehaviour
{

    public Item item;
    public ItemInventory inventory;

    public string howToUse;

    //public bool sendFungusMessage;

    //public Flowchart flowchart;

    

    public void Clicked()
    {        
        inventory.AddItem(this);

        gameObject.SetActive(false);        
    }
}
