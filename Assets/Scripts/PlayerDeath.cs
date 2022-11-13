

using StarterAssets;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{   
 
    void OnCollisionEnter(Collision enemyhit)
    {
        if (enemyhit.gameObject.CompareTag("Player"))  //checks whether the collider has the tag Player to proceed to the lost screen
        {
            Destroy(enemyhit.gameObject);
            FindObjectOfType<GameState>().endgame(); //Loads the Player Death scene
           
            
        }    
    }
}
