
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    
    void OnCollisionEnter(Collision enemyhit)
    {
        if (enemyhit.collider.tag == "Bird")
        {
            Debug.Log("CHECK SCM PLASTIC");
        }    
    }
}
