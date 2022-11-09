using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guns : MonoBehaviour
{

    public float dmg = 10f; //this variable has the value containing the damage applied to the objects after shooting
    public float range = 100f; //this variable defines the range for the bullet traversal
    public float fireRate = 15f;
    private float fireDelay = 0.1f;
    public int magSize = 25;
    private int currentAmmo;
    public float reloadDelay = 1f;
    private bool isReloading = false;

    public Camera gunCam;   //this is a camera reference used for shooting at where the camera is pointing
    //public ParticleSystem muzzle; //creates a reference for the particle system

    //public GameObject hitEffect; //referenced as game object to instantiate in the scene

    private void Start()
    {
        currentAmmo = magSize;
    }
    // Update is called once per frame
    void Update()
    {
        if (isReloading)
            return;

        if(currentAmmo<=0)//checks if current magazine is empty and triggers reload when empty
        {
           StartCoroutine(Reload());
            return;
        }
        if(Input.GetButton("Fire1") && Time.time >= fireDelay) //this condition checks if the player has pressed the fire button "Fire1" & Checks if the current time is greater or equal to the fire delay
        {
            fireDelay = Time.time + 1f / fireRate; //to add delay between the previous and the current bullet according to the firerate. if firerate=4 then 1/4 is 0.25 delay between bullets.
            Shoot();                    //This function will be called after the condition above is set to True
        }
    }

    IEnumerator Reload() //Adds delay for reloading after emptying current magazine 
    {
        isReloading = true;
        Debug.Log("Reloading");
        yield return new WaitForSeconds(reloadDelay);
        currentAmmo = magSize;
        isReloading = false;
    }
    void Shoot()
    {
        //muzzle.Play(); //triggers the muzzle particle system after receiving input from the user
        currentAmmo--;

        RaycastHit hit; //this variable will store the information about the objects the ray is hitting
        if(Physics.Raycast(gunCam.transform.position, gunCam.transform.forward, out hit, range)) //this will be used to shoot the ray within the set distance in forward direction where the camera is pointing and if hit at an object, gather its information
        {
            Debug.Log(hit.transform.name);
            BOTAI botai = hit.transform.GetComponent<BOTAI>(); //Target object created to get reference and pass damage value to the class BOTAI
            if(botai != null)
            {
                botai.Damage(dmg);
            }
        }

        if(hit.rigidbody != null)
        {

        }

       /* GameObject hitFx = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal)); //creates a hit effect at the point of the ray hit
        Destroy(hitFx, 1f);*/
    }
}
