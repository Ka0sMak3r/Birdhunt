using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunClass : MonoBehaviour
{
    public int pelletCount; //amount of pellets to fire
    public float spreadAngle; //wide angle for pellet spread
    public float fireRate = 1;
    public float dmg = 15f;

    public int magSize = 10;
    private int currentAmmo;
    public float reloadDelay = 2.8f;
    private bool isReloading = false;

    public GameObject bullet;
    public Transform barrel;
    public ParticleSystem muzzle; //creates a reference for the particle system
    AudioSource fire; //reference to the audio source attached to shotgun
    List<Quaternion> pellets;

    // Start is called before the first frame update
    void Start() 
    {
        fire = GetComponent<AudioSource>(); //initialization of audio source object
        currentAmmo = magSize;
        pellets = new List<Quaternion>(pelletCount); //Initialises a list of pellets w.r.t the pellet count
        for (int i = 0; i < pelletCount; i++)
        {
            pellets.Add(Quaternion.Euler(Vector3.zero));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isReloading) //if reloading, blocks weapon to fire
            return;

        if (currentAmmo <= 0)//checks if current magazine is empty and triggers reload when empty
        {
            StartCoroutine(Reload());
            return;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
          
        }
    }
    IEnumerator Reload()  //triggers a delay between firing for reloading
    {
        isReloading = true;
        Debug.Log("Reloading");
        yield return new WaitForSeconds(reloadDelay);
        currentAmmo = magSize;
        isReloading = false;
    }
    void shoot() //function to shoot bullets into the direction of where the barrel is facing
    {
        muzzle.Play(); //triggers the muzzle particle system after receiving input from the user
        fire.Play(); //triggers shooting sound after player shoots weapon
        currentAmmo--;
        for (int i = 0; i < pelletCount; i++)
        {
            pellets[i] = Random.rotation;
            GameObject blt = Instantiate(bullet, barrel.position, barrel.rotation);
            blt.transform.rotation = Quaternion.RotateTowards(blt.transform.rotation, pellets[i], spreadAngle);
            blt.GetComponent<Rigidbody>().AddForce(blt.transform.forward * fireRate);
            Destroy(blt, 1f);
        }
    }
        
  }

 
