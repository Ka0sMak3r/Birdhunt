
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{   
    
    void OnCollisionEnter(Collision enemyhit)
    {
        if (enemyhit.collider.tag == "Player")  //checks whether the collider has the tag Player to proceed to the lost screen
        {
            Debug.Log("Death Check");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Loads the Player Death scene
        }    
    }
}
