using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeBinTrash : MonoBehaviour
{
    OVRGrabbable grabScript;
    bool putted;

    void Start()
    {
        putted = false;
        grabScript = GetComponent<OVRGrabbable>();
    }

    void Update()
    {

    }

    void ResetPosition()
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
        if (putted)
        {
            return;
        }

        TrashManage tm = transform.parent.gameObject.GetComponent<TrashManage>();
        string tags = collision.gameObject.tag;
        if (tags == "ground")
        {
            tm.playFailAudio();
            ResetPosition();
        }
        else if (tags == "organBin") 
        {
            putted = true;
            tm.PutCorrect();
            tm.PutOne();
        }
        else if (tags == "blackBin" || tags == "blueBin")
        {
            tm.PutWrong();
            ResetPosition();
        }
    }
}
