using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmationPopup : MonoBehaviour
{

    public GameObject confirmationPopupBox;

    public string howToUse;
    public InventorySlot inventorySlot;

    

    public void SetPopupTask(string howToUseIn)
    {
        howToUse = howToUseIn;
    }

    public void SetPopupInventorSlot(InventorySlot inventorySlotIn)
    {
        inventorySlot = inventorySlotIn;
    }

    public void ShowPopup()
    {
       
           // bool isActive = confirmationPopupBox.activeSelf;
           // confirmationPopupBox.SetActive(!isActive);
            confirmationPopupBox.SetActive(true);
            confirmationPopupBox.GetComponent<ConfirmationPopupControl>().SetTask(howToUse, inventorySlot);
            
            
    }

}
