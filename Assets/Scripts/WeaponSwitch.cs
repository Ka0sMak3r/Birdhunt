using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public int currentWeapon = 0; //stores the index value for the current weapon selected

    // Start is called before the first frame update
    void Start()
    {
        WeaponSelect();
    }

    // Update is called once per frame
    void Update()
    {
        int previousWeapon = currentWeapon;
        if(Input.GetAxis("Mouse ScrollWheel")> 0f) //if axis > 0, scroll up
        {
            if (currentWeapon >= transform.childCount - 1) //checks if the index is greater or matches with the last weapon in the holster
                currentWeapon = 0;
            else
                currentWeapon++;   
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0f) //if axis < 0, scroll down
        {
            if (currentWeapon <= 0) 
                currentWeapon = transform.childCount - 1; 
            else
                currentWeapon--;
        }

        if(previousWeapon != currentWeapon) //checks if the current weapon is not as same as the previously equipped weapon, if true, triggers the WeaponSelect function.
        {
            WeaponSelect();
        }
    }

    void WeaponSelect() //function to enable and disable weapons based on the user selection
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
           
            if (i == currentWeapon)
            {
                weapon.gameObject.SetActive(true);
            }
            else
                weapon.gameObject.SetActive(false);
            i++;
        }
    }
}
