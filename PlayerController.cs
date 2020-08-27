using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class PlayerController : MonoBehaviour {

    Rigidbody body;

    public float speed;

    public Camera camera;

    public AudioClip triggerSound;
    public AudioClip gemSound;

    public CountdownTimer countdownTimer;

    public Flowchart Flowchart;

    // Use this for initialization
    void Start () {

        body = GetComponent<Rigidbody>();
       // triggerSound = GetComponent<AudioSource>();
       // gemSound = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {

        PlayerMove();
        PlayerRotate();

  
    }

    void PlayerMove()
    {

        Vector3 myVelocity = Vector3.zero;
   

        if(Input.GetKey(KeyCode.W))
        {
            myVelocity += transform.forward * 5;
        }
       /* if (Input.GetKey(KeyCode.S))
        {
            myVelocity += transform.forward * -5;
        }
        if (Input.GetKey(KeyCode.D))
        {
            myVelocity += transform.right * 5;
        }
        if (Input.GetKey(KeyCode.A))
        {
            myVelocity += transform.right * -5;
        }*/

        body.velocity = myVelocity;

    }

    void PlayerRotate()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit))
        {
        
                 Vector3 hitPoint = hit.point;

                 hitPoint.y = transform.position.y;

                transform.LookAt(hitPoint);
       
           
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Collider>().name == "AddTime")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(triggerSound);
            //triggerSound.Play();
            Destroy(other.GetComponent<Collider>().gameObject);
            countdownTimer.startingTime += 10;
        }

        if (other.GetComponent<Collider>().name == "Goal")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(gemSound);
            //countdownTimer.GetComponent<CountdownTimer>().timerText(Destroy);
            Destroy(other.GetComponent<Collider>().gameObject);
            //You get to the rescue point

            Flowchart.SetBooleanVariable("Done", true);

        }

    }

 

}
