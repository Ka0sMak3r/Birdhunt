using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public Transform[] spawn;
    public GameObject bfab;
    public float count=4f;

    
    public void enemySpawn()   //Spawns enemy at random location which shuffles between different spawn points
    {
        int randomNumber = Mathf.RoundToInt(Random.Range(0f, spawn.Length - 1));
        Instantiate(bfab, spawn[randomNumber].transform.position, Quaternion.identity);
    }
}
