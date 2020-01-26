using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBinTrash : MonoBehaviour
{
    // Start is called before the first frame update
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
        else if (tags == "blackBin")
        {
            putted = true;
            tm.PutCorrect();
            tm.PutOne();
            Invoke("SelfDestruct", 3);
        }
        else if(tags == "organBin" || tags == "blueBin")
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
