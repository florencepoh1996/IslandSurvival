using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementblock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
 
    }


    // Update is called once per frame
    void Update()
    {



       float xPos = Random.Range(-7, 7);

       // StartCoroutine(processTask());

        //how high
        float yVel = Random.Range(15, 23);

        float xVel = Random.Range(-4, 4);

    

        if (this.transform.position.y < -6)
        {

            

            xPos = Random.Range(-7, 7);

            if (xPos >= -3)
                xVel = Random.Range(-1, 6);
            if (xPos < 3)
                xVel = Random.Range(-6, 1);

           

            this.transform.position = new Vector2(xPos, -6);

            this.GetComponent<Rigidbody2D>().velocity = new Vector2(xVel, yVel);
        }
           
        }

        
    IEnumerator processTask()
    {
        yield return new WaitForSeconds(100.5f);
    }
  

    
}