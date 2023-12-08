using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disa_appear : MonoBehaviour
{
     public float delaytime;
    private float disappearingtime;
    private bool trigger = true;
    public float respawn_time;
    private bool respawn_trigger = false;
    private float coderespawntime;// this variable is use in the code to hold the value entered by the user without altering the given value.

    public GameObject log;

    // Start is called before the first frame update
    void Start()
    {
        disappearingtime = delaytime;
        coderespawntime =respawn_time;

    }

    // Update is called once per frame
    void Update()
    {
       
       // Debug.Log(frame_rate);
        //Debug.Log(oncetrigger);
       // Debug.Log("destroytime");
       // Debug.Log(destroytime);


            if (trigger == true)
            {
                disappearingtime -= Time.deltaTime;
        
            }

            if (disappearingtime < 0 )
            {
                log.gameObject.SetActive(false);
                Debug.Log("activate");
                trigger = false;
                respawn_trigger = true;
                 Debug.Log(respawn_trigger);


            }

            if (respawn_trigger == true){

                coderespawntime -= Time.deltaTime;
                Debug.Log(coderespawntime);
                disappearingtime = delaytime;
            }

            if (coderespawntime < 0){
                    respawn_trigger = false;
                    Debug.Log("launched");
                    log.gameObject.SetActive(true);
                    

                }



           if (respawn_trigger == false)
           {
            coderespawntime =respawn_time;
            trigger=true;


            }
    }
}
