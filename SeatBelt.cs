using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class SeatBelt : MonoBehaviour
{

    public float sliceTime = 0;
    public Flowchart Flowchart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DragStart()
    {
        Debug.Log("Drag Start");
        sliceTime = Time.time;
    }

    public void DragEnd()
    {
        Debug.Log("Drag End");

        if(Time.time - sliceTime < 0.5f)
        {
            Debug.Log("You sliced the belt!");
            Flowchart.SetBooleanVariable("beltcut", true);
        }

    }

}
