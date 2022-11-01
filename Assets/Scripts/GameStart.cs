using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameStart : MonoBehaviour
{
    
    public GameObject plr;
    public spawner spawn;
    private float delay = 5f;
    private void OnTriggerEnter(Collider ON)
    {
        if (ON.gameObject.tag == "Player")
        {
            spawn.enemySpawn();
        }
    }
}
