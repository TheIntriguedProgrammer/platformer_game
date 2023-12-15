using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameracontroller : MonoBehaviour
{

    public GameObject player;
    private float camera_x ;
    private float camera_y ;
    private float offset_x ; // offset the camera by the positon I set it as this prevents the camera being placed exact at the smae position of the player
    private float offset_y ; // same as above
    
    // Start is called before the first frame update
    void Start()
    {
       offset_x = transform.position.x - player.transform.position.x;
       offset_y = transform.position.y - player.transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 newposition = transform.position;
        camera_x = player.transform.position.x + offset_x; // assign player position x value to camera 
        camera_y = player.transform.position.y + offset_y; // assign player y position to the camera
        newposition.x = camera_x;
        newposition.y = camera_y;
        transform.position = newposition;



    }
}
