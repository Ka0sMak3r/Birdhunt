using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    [SerializeField] private Animator dooranim=null;
    [SerializeField] private bool opendoor=false;
    [SerializeField] private bool closedoor = false;
    

    private void OnTriggerEnter(Collider door)
    {
        if (door.CompareTag("Player"))
        {
            if (!opendoor)
            {
                dooranim.Play("DoorOpen", 0, 0f);
                GetComponent<Collider>().enabled = false;
            }
            else if(!closedoor)
            {
                dooranim.Play("DoorClose", 0, 0f);
                GetComponent<Collider>().enabled = false;
            }
        }
    }
}
