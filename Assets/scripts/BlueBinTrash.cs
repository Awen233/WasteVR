using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBinTrash : MonoBehaviour
{

    Rigidbody rigidBody;
    Vector3 initialPosition;
    float touchTime = 0.0f;
    float buildTime = 1.0f;
    bool  rightBin = false;
    OVRGrabbable grabScript;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        initialPosition = transform.position;
        grabScript = GetComponent<OVRGrabbable>(); 
    }

    void Update()
    {
        
    }

    void resetPosition()
    {
        print("trash reset the position");
        transform.position = initialPosition;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (grabScript.isGrabbed)
        {
            return;
        }
        string tags = collision.gameObject.tag;
        if (tags == "ground")
        {
            resetState();
            resetPosition();
        } else if(tags ==  "blueBin") {
            TrashManage tm = transform.parent.gameObject.GetComponent<TrashManage>();
            tm.putOne();
        } else if(tags == "organBin")
        {
            resetState();
            resetPosition();
        }
    }

    //private void OnCollisionStay(Collision collision)
    //{
    //    if(rightBin == false || grabScript.isGrabbed)
    //    {
    //        return; 
    //    }
    //    if(touchTime >= 3)
    //    {
    //        TrashManage tm = transform.parent.gameObject.GetComponent<TrashManage>();
    //        tm.putOne();
    //    } else
    //    {
    //        touchTime += buildTime * Time.deltaTime;
    //    }

    //}

    private void OnCollisionExit(Collision collision)
    {
        if (rightBin)
        {
            resetState(); 
        }
    }

    void resetState()
    {
        touchTime = 0.0f;
        buildTime = 1.0f;
        rightBin = false;
    }

    

}
