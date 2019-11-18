using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBinTrash : MonoBehaviour
{

    OVRGrabbable grabScript;

    void Start()
    {
        grabScript = GetComponent<OVRGrabbable>(); 
    }

    void Update()
    {
        
    }

    void resetPosition()
    {
        TrashManage pare = transform.parent.GetComponent<TrashManage>();
        transform.position = pare.getInitial();
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (grabScript.isGrabbed)
        {
            return;
        }
        TrashManage tm = transform.parent.gameObject.GetComponent<TrashManage>();
        string tags = collision.gameObject.tag;
        if (tags == "ground")
        {
            tm.playFailAudio();
            resetPosition();
        } else if(tags ==  "blueBin") {
            
            tm.PlaySuccessAudio();
            tm.putOne();
        } else if(tags == "organBin")
        {
            tm.playFailAudio();
            resetPosition();
        }
    }
}
