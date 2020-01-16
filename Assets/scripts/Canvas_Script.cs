using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Script : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource audioSource;

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
        if (Input.GetKey(KeyCode.LeftArrow))
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
