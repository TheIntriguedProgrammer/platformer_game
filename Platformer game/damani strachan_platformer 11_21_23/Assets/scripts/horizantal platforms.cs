using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizantalplatforms : MonoBehaviour
{   


    public float movement_speed;
    private Vector3 origin;
    //public int code_rate; // this variable is used to regulate the turn back speed of the platform
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newposition = transform.position;
        origin = newposition;
        if (newposition == origin)
        {
            Debug.Log("1");
        }
    }
}

///void movement()
//{
  //  if (newposition.x < travel_distance && newposition.x != travel_distance && loop = false)
   //{
   //     newposition.x += movement_speed;
   // }

  //  if (newpostion.x == travel_distance)
  //  {

  //      loop = true;
  //  }

  //  if (newposition.x > origin && newposition.x != origin && loop = true)
  //  {
  //      newposition.x -= movement_speed;
   // }
   // if (newposition.x == origin)
   // {
    //    loop = false;
///
/// 
/// 
/// 
/// 
///



