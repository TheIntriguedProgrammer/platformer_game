using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappearingground : MonoBehaviour
{
    public float delaytime;
    private float destroytime;
    private bool oncetrigger=false;
    private int respawn_time;
    public GameObject log;

    // Start is called before the first frame update
    void Start()
    {
        destroytime = delaytime;
    }

    // Update is called once per frame
    void Update()
    {
       
       // Debug.Log(frame_rate);
        //Debug.Log(oncetrigger);
       // Debug.Log("destroytime");
       // Debug.Log(destroytime);


            if (oncetrigger == true)
            {
                destroytime -= Time.deltaTime;
        
            }

            if (destroytime < 0 )
            {
                this.gameObject.SetActive(false);
                Debug.Log("activate");
                oncetrigger = false;

            }


        
           


            



        
    }

    private void OnCollisionEnter2D(Collision2D collision){

        if (collision.gameObject.tag.Equals("Player")){

            oncetrigger=true; // changes when the player lands on the platform.
            Debug.Log("landed");

        }

    }
}
