
using UnityEngine;

public class BOTAI : MonoBehaviour
{
    public GameObject target;
    public Transform myTransform;

    private void Start()
    {
       target = GameObject.Find("FPSController");
    }
    void Update()
    {
        transform.LookAt(target.transform);
        transform.Translate(Vector3.forward * 5 *Time.deltaTime);
    }


}
