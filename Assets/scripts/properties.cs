using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class properties : MonoBehaviour
{
    public int VideoNum;
    public Vector3 startpos;
    public Vector3 playpos;
    private bool grabbed;

    // Start is called before the first frame update
    void Start()
    {
         startpos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var pos = gameObject.transform.position;
        if (pos.x>2.2||pos.z>-1||pos.x<-3||pos.z<-5 || pos.y<= .16)
        {
            ReturntoStart();
        }

         grabbed = gameObject.GetComponent<OVRGrabbable>().isGrabbed;

        if (grabbed)
        {
            GameObject video = GameObject.Find("Trigger");
           // if (video.GetComponent<cartridge>().Eject(grabbed, VideoNum))
                //ReturntoStart();
        }
    }

    public void ReturntoStart()
    {
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        gameObject.transform.position = startpos;
    }

    public void PlaySet()
    {
        GetComponent<OVRGrabbable>().enabled = false;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        transform.rotation = Quaternion.Euler(0, 0, 0);
        transform.position = playpos;

    }
}
