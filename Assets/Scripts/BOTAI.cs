
using UnityEngine;

public class BOTAI : MonoBehaviour
{
    public GameObject target;
    public Transform myTransform;
    public KillCounter killCounter;

    public float health = 25f; //target health
    //public ParticleSystem dmgEffect; //reference for the particle system to trigger damage effect

    public void Damage(float dmgtaken) //function for applying damage to the AI and if health reaches 0, the enemy dies
    {
        health -= dmgtaken;

        /*GameObject dmgfx = Instantiate(dmgEffect.gameObject, gameObject.transform.position, Quaternion.identity);
        Destroy(dmgfx,1f);*/
        if (health <= 0f)
        {
    
            EnemyDeath();

        }

    }

    void EnemyDeath() // function to destroy the object when the health reaches 0
    {
        
        Destroy(gameObject);
        killCounter.KillIncrement();
    }

    private void Start()
    {
        killCounter = GameObject.Find("KCO").GetComponent<KillCounter>();
        target = GameObject.Find("FPSController");
        
    }
    void Update() //Method assigned to the enemy to track the player - https://www.youtube.com/watch?v=6ZkvUu4HFKI
    {
        transform.LookAt(target.transform);
        transform.Translate(Vector3.forward * 4 * Time.deltaTime);
    }

}
