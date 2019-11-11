using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBinTrash : MonoBehaviour
{

    Rigidbody rigidBody;
    Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void resetPosition()
    {
        print("trash reset the position");
        transform.position = initialPosition;
    }

    void OnCollisionEnter(Collision collision)
    {
        string tags = collision.gameObject.tag;
        if (tags == "ground")
        {
            resetPosition();
        } else if(tags ==  "blueBin") {
            TrashManage tm = transform.parent.gameObject.GetComponent<TrashManage>();
            tm.putOne();
        } else if(tags == "organBin")
        {
            resetPosition();
        }
    }
}
