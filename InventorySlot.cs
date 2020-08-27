using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public CollectableItem item;
    public GameObject icon;
    public ItemInventory inventory;
    public string howToUse;

    public ConfirmationPopup popup;
   

    

    public void UpdateSlot()
    {
        if(item != null)
        {
            icon.GetComponent<Image>().sprite = item.item.icon;
            icon.SetActive(true); 
          
        }
        else
        {
            //icon.SetActive(false);
        }
    }

    public void RemoveThisItem()
    {
        inventory.RemoveItem(item);
        item = null;
        UpdateSlot();
        
    }

    public void UseItem()
    {
        //This is where we decide how to use the item
        Debug.Log("I am going to: " + howToUse);

        popup.SetPopupTask(howToUse);
        popup.SetPopupInventorSlot(this);
        popup.ShowPopup();
    }

   
}
