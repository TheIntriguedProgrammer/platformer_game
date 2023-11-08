using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hori_platformer : MonoBehaviour
{


    public float movement_speed;
    public float endpoint;
    private float origin;
    private bool endstop = false;
    //public int code_rate; // this variable is used to regulate the turn back speed of the platform
    // Start is called before the first frame update
    void Start()
    {
        origin = transform.position.x;
        Debug.Log(origin);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newposition = transform.position;
        
        if (newposition.x < endpoint && endstop == false)
        {
            newposition.x += movement_speed;
        }
        if (newposition.x > endpoint)
        {
            Debug.Log("it works thank God");
            endstop = true;
        }
        if (newposition.x > origin && endstop == true)
        {
            newposition.x -= movement_speed;
        }
        if (newposition.x == origin)
        {
            endstop = false;
        }




       // if (newposition.x == origin)
       // {
       //     Debug.Log("1");
            
       // }

        Debug.Log(newposition.x);
      








        transform.position = newposition;
 
    
    
    
    
    
    
    
    
    
    
    }

    void hoverplatform()
    {

    }











}
