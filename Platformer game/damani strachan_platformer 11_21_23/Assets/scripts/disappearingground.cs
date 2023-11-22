using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappearingground : MonoBehaviour
{
    private int frame_rate = 0;
    public int delaytime;
    private int destroytime;
    private bool oncetrigger=false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        frame_rate += 1;
       // Debug.Log(frame_rate);
        //Debug.Log(oncetrigger);
       // Debug.Log("destroytime");
       // Debug.Log(destroytime);


            if (oncetrigger == true)
            {
                destroytime = frame_rate + delaytime;
                oncetrigger = false; }

            if (frame_rate == destroytime && oncetrigger == false)
            {
                Destroy(this.gameObject);
                Debug.Log("activate");

            }

            



        
    }

    private void OnCollisionEnter2D(Collision2D collision){

        if (collision.gameObject.tag.Equals("Player")){

            oncetrigger=true;
            Debug.Log("landed");

        }

    }
}
