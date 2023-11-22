using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private int framerate = 0;
    private bool ratetrigger =  false;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ratetrigger == true){
            framerate = framerate +1;
            Debug.Log(framerate);
        }

    }



    private void OnCollisionEnter2D(Collision2D collision){

        if (collision.gameObject.tag.Equals("board")){
            Debug.Log("land on the platform");
            ratetrigger = true;
        }
    }
}


