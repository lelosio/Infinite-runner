using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//kod na zabicie playera przez przeszkode

public class Obstacle : MonoBehaviour
{

    player player;

    void Start()
    {
        player = GameObject.FindObjectOfType<player>();
    }

     private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            player.Die();
    }


    void Update()
    {
        
    }
}
