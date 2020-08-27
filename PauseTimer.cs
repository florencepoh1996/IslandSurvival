using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseTimer : MonoBehaviour
{

    bool isPaused = false;


   public void pauseTimer()
   {
      

        if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
        } else
        {
            Time.timeScale = 0;
        }

    }
    
}
