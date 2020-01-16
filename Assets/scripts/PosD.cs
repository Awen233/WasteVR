using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosD : MonoBehaviour
{
    //private Vector3 position = new Vector3(0f, 9.256276f, 7.420009f);
    private Vector3 position = new Vector3(0f, 159.4459f, -80.00943f);
    private float num;
    public static bool dHit = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        num = ItemLoader.choiceArr[text.tempInt];
        if (num == 2)
        {
            position.x = 99999f;
        }
        else if (num == 3)
        {
            position.x = 99999f;
        }
        else if (num == 4)
        {
            position.x = -175.5534f;
        }
        else
        {
            position.x = -175.797f;
        }
        transform.position = position;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            dHit = true;
        }
    }
}
