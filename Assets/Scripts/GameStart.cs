using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
public class GameStart : MonoBehaviour
{
    
    public GameObject plr;
    public spawner spawn;
    private float delay=5f;
    private bool ActivateTimer = false;
    public AudioSource audioSource;

     private void Update() //Delay function to spawn enemies
     {
         if (ActivateTimer)
         {
             delay -= Time.deltaTime;
             if (delay <= 0)
             {
                 spawn.enemySpawn();
             }
         }
     }
    

    private void OnTriggerEnter(Collider ON)    //Checks if the player has entered the trigger
    {
        
       
        if (ON.gameObject.tag == "Player" && !audioSource.isPlaying)
        {
            ActivateTimer = true;
            audioSource.Play(); //Plays music after entering the game arena
            GetComponent<Collider>().enabled = false; //Stops the spawn trigger after triggering it once
        }
    }
    
}
