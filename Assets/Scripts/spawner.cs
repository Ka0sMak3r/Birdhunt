using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public Transform[] spawn;
    public GameObject bfab;
    private float timer;
    private bool ActivateSpawn=false;
    private bool doonce=false;

    public void Update() //Timer Function to activate 4 enemies after 5 seconds
    {
        if (ActivateSpawn) 
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                doonce = true;
                enemySpawn();
                timer = 5;

            }
        }
    }
    public void enemySpawn()   //Spawns 4 enemy at random location which shuffles between different spawn points
    {
        if (!ActivateSpawn) //checks if the Spawn is not active, if not active, spawns enemies
        {
            int randomNumber = Mathf.RoundToInt(Random.Range(0f, spawn.Length - 1)); //chooses random spawn to spawn enemies
            Instantiate(bfab, spawn[randomNumber].transform.position, Quaternion.identity); //enemy spawner
            ActivateSpawn = true; 
        }
        else
        {
            if (doonce)    //Checks if the spawn is activated, if not, activates the spawn
            {

                for (int i = 0; i < 4; i++)
                {
                    int randomNumber = Mathf.RoundToInt(Random.Range(0f, spawn.Length - 1));//chooses random spawn to spawn enemies
                    Instantiate(bfab, spawn[randomNumber].transform.position, Quaternion.identity);//enemy spawner
                }
                doonce = false; //Shuts off the spawner for 5 seconds 
            }
        }
    }
}
