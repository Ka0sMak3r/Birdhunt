using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator dooranim;
    public GameObject player;
    private void OnTriggerEnter(Collider doorp)
    {
        if (doorp.gameObject.tag == "Player")
        {
            dooranim.SetBool("isPresent", true);
        }

       
    }
    private void OnTriggerExit(Collider other)
    {
        dooranim.SetBool("isPresent", false);
    }


}
