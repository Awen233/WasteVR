using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBinTrash : MonoBehaviour
{

    OVRGrabbable grabScript;
    bool putted;

    void Start()
    {
        putted = false;
        grabScript = GetComponent<OVRGrabbable>();
        print("the grabScript is : " + grabScript);
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
        else if (tags == "blueBin")
        {
            putted = true;
            tm.PutCorrect();
            tm.PutOne();
            Invoke("SelfDestruct", 7);
        }
        else if (tags == "organBin" || tags == "blackBin")
        {
            tm.PutWrong();
            ResetPosition();
        }
    }

    void SelfDestruct()
    {
        gameObject.SetActive(false);
    }
}

