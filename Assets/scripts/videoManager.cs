using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videoManager : MonoBehaviour
{
    public VideoClip[] videoClips;

    // Start is called before the first frame update
    void Start()
    {
        var videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            PlayVideo(0);
        if (Input.GetKeyDown(KeyCode.Alpha2))
            PlayVideo(1);
        if (Input.GetKeyDown(KeyCode.Alpha3))
            PlayVideo(2);
    }

   public void PlayVideo(int i)
    {
        var videoPlayer = GetComponent<VideoPlayer>();

        videoPlayer.Stop();
       
        videoPlayer.clip = videoClips[i];
        videoPlayer.Play();

        GameObject signal = GameObject.Find("CurrentVid");
        signal.GetComponent<whatVid>().currentVid(i);
    }
}
