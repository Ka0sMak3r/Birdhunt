
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    
    void OnCollisionEnter(Collision enemyhit)
    {
        if (enemyhit.collider.tag == "Player")  //DEATH CHECK WORKING JUST need to add Video
        {
            Debug.Log("Death Check");
        }    
    }
}
