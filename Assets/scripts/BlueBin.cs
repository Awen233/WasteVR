using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        string tags = collision.gameObject.tag;
        if (tags == "blue")
        {
            print("you put it correct");
        }
        else
        {
            print("you put it wrong");
        }
    }
}
