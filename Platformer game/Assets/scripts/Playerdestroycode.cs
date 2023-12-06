using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerdestroycode : MonoBehaviour
{

    // position of the player start 
    private float origin_x;
    private float origin_y;
    public float respawndelay;
    private bool Dead = false;
    private bool respawned = true;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
       origin_x = player.transform.position.x;
       origin_y = player.transform.position.y;
       Debug.Log(origin_x);

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = player.transform.position;
        if (Dead == true)
        {
            respawndelay -= Time.deltaTime;
            if (respawndelay < 0)
            {
                Dead = false;
                respawned = false;
            }

        }

        if (Dead == false && respawned == false)
        {
            newPosition.x = origin_x;
            newPosition.y = origin_y;
            player.gameObject.SetActive(true);
            respawned=true;
        }


       player.transform.position = newPosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("hit your dead");
            Dead = true;
            player.gameObject.SetActive(false);

        }
    }

}
