using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappearingground : MonoBehaviour
{
    private int frame_rate = 0;
    public int delaytime;
    private int destroytime;
    private bool oncetrigger = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        frame_rate += 1;



        
    }

    private void OnCollisionEnter2D(Collision2D collision){

        if (collision.gameObject.tag.Equals("Player")){
            if (oncetrigger == true){
                destroytime = frame_rate + delaytime;
                oncetrigger = false; }
            if (oncetrigger == false && destroytime == frame_rate){
                Destroy(this.gameObject);

            }
            

        }

    }
}
