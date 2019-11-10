using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeTest : MonoBehaviour
{
    Rigidbody rigidBody;
    Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        print("start");
        rigidBody = GetComponent<Rigidbody>();
        initialPosition = rigidBody.position;
        resetPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void resetPosition()
    {
        print("lets reset the position");
        rigidBody.position = initialPosition;
    }

    void OnCollisionEnter(Collision collision)
    {
        print("collsion happen");
        string tags = collision.gameObject.tag;
        if(tags == "ground")
        {
            print("we collide with ground");
            resetPosition();
        } 
        else
        {
            print("nothing happen");
        }
    }

}
