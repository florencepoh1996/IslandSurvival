using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenSettingsScript : MonoBehaviour
{
    private int currentSceneIndex;

    public void OpenSettings(string scenename)
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentSceneIndex);
        Application.LoadLevel(scenename);
    }
}
