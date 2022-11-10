using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
    public Animator dooranim;
    public bool open = true;
    public GameObject plr;
    private void OnTriggerEnter(Collider doorb)
    {
        if (doorb.gameObject.tag == "Player")
        {
            if (!open)
            {
                dooranim.Play("AutoDoor", 3 , 0f);
                
            }
        }
    }
}
