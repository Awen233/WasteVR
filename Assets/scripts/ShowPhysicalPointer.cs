using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShowPhysicalPointer : MonoBehaviour
{
    [SerializeField] OVRPhysicsRaycaster ray;
    [SerializeField] LaserPointer laser;
    bool showLaser;

    void Start()
    {
        ray.enabled = false;
        laser.enabled = false; 
        print("ray enabled is " + ray.enabled);
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            showLaser = !showLaser;
            if (showLaser)
            {
                ray.enabled = true;
                laser.enabled = true;
            } else
            {
                ray.enabled = false;
                laser.enabled = false;
            }
        }
    }
}
