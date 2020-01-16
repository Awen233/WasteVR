using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio2 : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        keyPressOps();
    }

    private void keyPressOps()
    {
        if (Input.GetKey(KeyCode.Space))
        {

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //daText.gameObject.SetActive(true);
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
            else
            {
                audioSource.Stop();
            }
        }


    }
}
