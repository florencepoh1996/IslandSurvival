using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    
    public List<CollectableItem> itemList = new List<CollectableItem>();
    public List<InventorySlot> inventorySlots = new List<InventorySlot>();
    public Text bagFullText;

    

    private bool Add(CollectableItem item)
    {

        for(int i = 0; i < itemList.Count; i++)
        {
            if(itemList[i] == null)
            {
                itemList[i] = item;
                inventorySlots[i].item = item;
                return true;
            }
        }
        return false;

    }

    public void UpdateSlotUI()
    {
       
        for (int i = 0; i < inventorySlots.Count; i++)
        {
            inventorySlots[i].item = null;
        }

        foreach(CollectableItem item in itemList)
        {
            inventorySlots[itemList.IndexOf(item)].item = item;
        }
        for (int i = 0; i < inventorySlots.Count; i++)
        {
            inventorySlots[i].UpdateSlot();
        }

    }

    public void AddItem(CollectableItem item)
    {
       

        if(itemList.Count < 20)
        {
            itemList.Add(item);
            
            UpdateSlotUI();
        } else
        {
           bagFullText.text = "Your bag is full! Please remove any items that you don't need.";
            Destroy(bagFullText, 5);
        }
        

    }

 

    public void UseItem(InventorySlot slot)
    {
        CollectableItem thisItem = slot.item;

       // HealthBar.curHealth


        //Make popup window appear with item sprite or somethis....
        //Do you want to use this item???
        //If ok clicked, Remove item plus do whatevs and close popup...
        //if not...close popup and do nada
    }

    public void RemoveItem(InventorySlot slot)
    {
        CollectableItem thisItem = slot.item;

        if(itemList.Contains(thisItem)) {
            itemList.Remove(thisItem);
            UpdateSlotUI();
            Debug.Log("Removing: " + thisItem.item.itemName);
        }
        
    }

}
