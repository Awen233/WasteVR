using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBin : MonoBehaviour
{
    Transform particle;

    // Start is called before the first frame update
    void Start()
    {
        particle = transform.Find("particuleCube");
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision collision)
    {
        string tags = collision.gameObject.tag;
        if (tags == "blueBinTrash")
        {
            print("correct");
            Invoke("playParticle", 1);
        }
    }

    void playParticle()
    {
        testPar test = particle.gameObject.GetComponent<testPar>();
        test.playParticle();
    }
}
