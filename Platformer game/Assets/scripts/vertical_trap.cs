using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vertical_trap : MonoBehaviour
{
    public float movement_speed; // is as the name suggest controlls the speed of the trap movement
    public float endpoint; // this is the endpoint of the plunger of death
    public float stop_time; // this is the delay stop time of the trap before it returns to its start
    public float delay_start_time; // this is the delay period before the plunger is triggered
    private float origin; // the start x value of the plunger 
    private float starting_timer;// this is just a temp holding variable
    private float stop_timer;// this is just a temp holding variable
    private bool endstop = false;
    private bool timer_trigger = true;
    private bool trigger_movement;// moves the trap
    // Start is called before the first frame update
    void Start()
    {
        origin = transform.position.y;
        starting_timer = delay_start_time;
        stop_timer = stop_time;
        Debug.Log("origin");
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 newposition = transform.position;

        if (timer_trigger == true)
        {

            if (endstop == false)
            {
                starting_timer -= Time.deltaTime;
                Debug.Log("starting_timer");
                Debug.Log(starting_timer);
            }

            if (endstop == true)
            {
                stop_timer -= Time.deltaTime;
                Debug.Log("stop_timer");
                Debug.Log(stop_timer);
            }




        }

        if (starting_timer < 0 && newposition.y > endpoint && endstop == false)
        {
            timer_trigger = false;
            newposition.y -= movement_speed;
            Debug.Log("moving out well it should be");
            Debug.Log(timer_trigger);


        }

        if (newposition.y < endpoint)
        {
            Debug.Log(" state change endstop equal true");
            endstop = true;
            starting_timer = delay_start_time;
            timer_trigger = true;
            Debug.Log(timer_trigger);



        }

        if (stop_timer < 0 && newposition.y < origin && endstop == true)
        {
            timer_trigger = false;
            newposition.y += movement_speed;
            Debug.Log("moving in the the wall should be ahh");
        }

        if (newposition.y > origin || newposition.y == origin)
        {
            endstop = false;
            stop_timer = stop_time;
            timer_trigger = true;
        }


        transform.position = newposition;



    }
}