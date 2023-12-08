using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappearingground : MonoBehaviour
{
    public float delaytime;
    private float destroytime;
    private bool oncetrigger=false;
    public float respawn_time;
    private bool respawn_trigger = false;
    private float coderespawntime;// this variable is use in the code to hold the value entered by the user without altering the given value.

    public GameObject log;

    // Start is called before the first frame update
    void Start()
    {
        destroytime = delaytime;
        coderespawntime =respawn_time;

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
                log.gameObject.SetActive(false);
                Debug.Log("activate");
                oncetrigger = false;
                respawn_trigger = true;
                 Debug.Log(respawn_trigger);


            }

            if (respawn_trigger == true){

                coderespawntime -= Time.deltaTime;
                Debug.Log(coderespawntime);
                destroytime = delaytime;
            }

            if (coderespawntime < 0){
                    respawn_trigger = false;
                    Debug.Log("launched");
                    log.gameObject.SetActive(true);
                    

                }



           if (respawn_trigger == false)
           {
            coderespawntime =respawn_time;


            }
            


        
           


            



        
    }

    private void OnCollisionEnter2D(Collision2D collision){

        if (collision.gameObject.tag.Equals("Player")){

            oncetrigger=true; // changes when the player lands on the platform.
            Debug.Log("landed");

        }

    }
}