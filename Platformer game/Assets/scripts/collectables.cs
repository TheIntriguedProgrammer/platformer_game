using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectables : MonoBehaviour
{
    public AudioSource collectablesound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OncollisionEnter2D(Collision2D collision){

        if (collision.gameObject.tag.Equals("squares")){
            Debug.Log("ahh got it");
            collectablesound.Play();
            Destroy(this.gameObject);//This destroy the object on collection

        }
    }
}

