using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SGDmg : MonoBehaviour
{
    public float damage = 15f;
    private void OnCollisionEnter(Collision collision) //function for applying damage to enemy after collision with pellets
    {
        BOTAI botai = collision.collider.gameObject.GetComponent<BOTAI>();
        if (botai != null)
        {
            Debug.Log("Damaged");
            botai.Damage(damage);
        }
    }
}
