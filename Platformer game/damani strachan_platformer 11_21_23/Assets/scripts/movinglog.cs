using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movinglog : MonoBehaviour
{


    public float movement_speed;
    public float endpoint;// end point must be greater than origin
    private float origin;
    private bool endstop = false;
    //public int code_rate; // this variable is used to regulate the turn back speed of the platform
    // Start is called before the first frame update
    void Start()
    {
        origin = transform.position.y;
        Debug.Log(origin);
        Debug.Log("origin");

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newposition = transform.position;

        if (newposition.y < endpoint && endstop == false)
        {
            newposition.y += movement_speed;
        }
        if (newposition.y > endpoint)
        {
            Debug.Log("it works thank God");
            endstop = true;
        }
        if (newposition.y > origin && endstop == true)
        {
            newposition.y -= movement_speed;
        }
        if (newposition.y < origin)
        {
            endstop = false;
        }




        // if (newposition.x == origin)
        // {
        //     Debug.Log("1");

        // }
        Debug.Log("current");
        Debug.Log(newposition.y);
        Debug.Log(endstop);


        transform.position = newposition;











    }


}