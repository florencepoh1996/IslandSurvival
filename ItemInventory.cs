using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInventory : MonoBehaviour
{

    public List<CollectableItem> items = new List<CollectableItem>();

    public List<InventorySlot> inventorySlots = new List<InventorySlot>();    

    

    public void AddItem(CollectableItem itemToAdd)
    {
        if(!items.Contains(itemToAdd))
        {
            items.Add(itemToAdd);
        }

        UpdateSlots();
    }

    public void RemoveItem(CollectableItem itemToRemove)
    {
        if (items.Contains(itemToRemove))
        {
            items.Remove(itemToRemove);
            //Destroy(itemToRemove);
        }

        UpdateSlots();
    }
        

    public void UpdateSlots()
    {
        foreach(InventorySlot slot in inventorySlots)
        {
            slot.gameObject.SetActive(false);
            slot.item = null;
        }

        
        for(int i = 0; i < items.Count; i++)
        {
            inventorySlots[i].gameObject.SetActive(true);
            inventorySlots[i].item = items[i];
            inventorySlots[i].howToUse = items[i].howToUse;
            inventorySlots[i].UpdateSlot();
        }
        
    }


}
