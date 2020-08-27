using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

   public Slider healthBarSlider;
    public int curHealth;
    public int maxHealth;
    public Text healthText;

    public Text deadText;
    public Text aliveText;


    void Start()
    {
        InvokeRepeating("ReduceHealth", 90, 90);
       
    }

    // Update is called once per frame
    void Update()
    {
        healthBarSlider.maxValue = maxHealth;
        healthBarSlider.value = curHealth;
        healthText.text = "Health: " + curHealth.ToString() + " / " + maxHealth.ToString();

        if (curHealth == 0)
        {
            curHealth = 0;
            HealthZero("HealthLow");
           

        }

        if (curHealth == 20)
        {
            deadText.text = "Your health is running low!";
            Destroy(deadText, 4);
        }

        if (curHealth >= 100)
        {
            curHealth = 100;
            aliveText.text = "You have full health!";
            Destroy(aliveText, 4);
        }

   
    }

    public void ReduceHealth()
    {
        curHealth = curHealth - 5;
        
        if(curHealth == 0)
        {
            CancelInvoke();
           
        }
     
    }

    public void HealthZero(string scenename)
    {
        Application.LoadLevel(scenename);
    }

}
