using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cartridge : MonoBehaviour
{
    private GameObject playingVid;
    private int VideoPlayNum;
    Vector3 playingPos = new Vector3(-1.11f, 1.13f,-3.51f);

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.tag == "video")
        {
            VideoPlayNum = other.GetComponent<properties>().VideoNum;

            GameObject video = GameObject.Find("Video");
            video.GetComponent<videoManager>().PlayVideo(VideoPlayNum);

            other.GetComponent<properties>().ReturntoStart();
            //playingVid = other.gameObject;
            //playingVid.GetComponent<OVRGrabbable>().enabled= false;
            //playingVid.transform.position = playingPos;
        }    
    }
}
