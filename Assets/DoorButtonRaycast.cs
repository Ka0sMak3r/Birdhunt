using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
public class DoorButtonRaycast : MonoBehaviour
{
   /* [SerializeField] private int raylength=5;
    [SerializeField] private LayerMask interact;
    [SerializeField] private string excludeLayer = null;
    private DoorButtonController controller;
    [SerializeField] KeyCode opendoor = KeyCode.E;
    private bool isCrosshairActive;
    private bool doOnce;
    private const string iteracttag = "DoorButton";

    private void Update()
    {
        RaycastHit hitd;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        int mask = 1 << LayerMask.NameToLayer(excludeLayer) | interact.value;
        if (Physics.Raycast(transform.position, fwd, out hitd, raylength, mask))
        {
            if (hitd.collider.CompareTag("DoorButton"))
            {
                if (!doOnce)
                {
                    controller = hitd.collider.gameObject.GetComponent<DoorButtonController>();
                }
                isCrosshairActive = true;
                doOnce = true;
                if (Input.GetKeyDown(opendoor))
                {
                    controller.playanimatiion();
                }
            }
        }
        
    }
   */
}
