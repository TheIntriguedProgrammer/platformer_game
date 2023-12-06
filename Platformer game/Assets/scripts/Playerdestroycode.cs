using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerdestroycode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Dead != false)
        {
            respawndelay -= Time.deltaTime;
            if (respawndelay > 0)
            {
                Debug.Log("TESTING");
            }

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("hit your dead");
            Dead = true;
            Player.gameObject.SetActive(false);

        }
    }
}
