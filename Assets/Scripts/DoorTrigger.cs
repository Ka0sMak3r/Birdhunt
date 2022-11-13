using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator dooranim; 
    public GameObject player;

    //Door animation controller Script
    private void OnTriggerEnter(Collider doorp) 
    {
        if (doorp.gameObject.tag == "Player")
        {
            dooranim.SetBool("isPresent", true); //Door Animation Enabled
        }

       
    }
    private void OnTriggerExit(Collider other)
    {
        dooranim.SetBool("isPresent", false); //Door Animation Disabled
    }


}
