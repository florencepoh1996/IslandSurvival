using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsToggle : MonoBehaviour
{
    public GameObject settingMenu;
    


    public void toggleMenu()
    {
        if (settingMenu != null)
        {
            bool isActive = settingMenu.activeSelf;

            settingMenu.SetActive(!isActive);
        }

    }

    

}
