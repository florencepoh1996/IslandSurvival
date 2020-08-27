using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{


    public float startingTime = 60f;
    public Text timerText;

    public Color newColor;
    public Color standardColor;



    // Update is called once per frame
    void Update()
    {
        startingTime -= 1 * Time.deltaTime;
        timerText.text = "Timer: " + startingTime.ToString("0") + " seconds";


        if (startingTime < 15)
        {
            timerText.color = newColor;
        }
        if (startingTime > 15)
        {
            timerText.color = standardColor;
        }




        if (startingTime <= 0)
        {
            startingTime = 0;
            Destroy(timerText);
            Timeout("LostInMaze");

        }
        if (startingTime >= 60)
        {
            startingTime = 60;
        }


    }

    public void Timeout(string scenename)
    {
        Application.LoadLevel(scenename);
    }
}
