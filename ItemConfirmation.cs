using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemConfirmation : MonoBehaviour
{
    public GameObject NoButton;

    public void ClosePanel()
    {
        if (NoButton != null)
        {
            bool isActive = NoButton.activeSelf;

            NoButton.SetActive(!isActive);
        }


    }

}
