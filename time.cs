using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{

    public float startingTime = 30f;
    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        startingTime -= 1 * Time.deltaTime;
        timerText.text = "Timer:" + startingTime.ToString("0") + " seconds";

        if(startingTime <= 0)
        {
            startingTime = 0;
        }


    }
}
