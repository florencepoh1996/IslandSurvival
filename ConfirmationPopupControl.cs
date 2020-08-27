using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class ConfirmationPopupControl : MonoBehaviour
{

    public string howToUse;
    public InventorySlot inventorySlot;
     

    public HealthBar healthBar;
    //public GameObject inventory;
    public GameObject popup;

    public Flowchart Flowchart;
    
    public void SetTask(string howToUseIn, InventorySlot inventorySlotIn)
    {
        howToUse = howToUseIn;
        inventorySlot = inventorySlotIn;
    }

    public void YesPressed()
    {
        
        Debug.Log("The task is:" + howToUse);

        if(howToUse == "Eat Food")
        {
            //add health to the player
            healthBar.curHealth += 10;
        }
        else if(howToUse == "Health Decrease")
        {
            
            healthBar.curHealth -= 10;
            
        }  else if(howToUse == "Radio Game")
        {
            Flowchart.SetBooleanVariable("radio", true);
            

        }
        popup.SetActive(false);
        //gameObject.SetActive(false);
        inventorySlot.RemoveThisItem();
       

    }

    public void NoPressed()
    {

        gameObject.SetActive(false);
    }

}
