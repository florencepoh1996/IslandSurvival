using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseSettingsScript : MonoBehaviour
{
    private int continueScene;

    public void closeSettingsMenu()
    {
        continueScene = PlayerPrefs.GetInt("SavedScene");

        if (continueScene != 0)
        {
            SceneManager.LoadScene(continueScene);
        } else
        {
            return;
        }
    }
}
