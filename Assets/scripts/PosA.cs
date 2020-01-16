using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosA : MonoBehaviour
{
    private Vector3 position = new Vector3( 0f, 159.4459f, -80.00943f);
    private float num;
    public static bool aHit = false;
    
    // Start is called before the first frame update
    void Start()
    {
        var boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        num = ItemLoader.choiceArr[text.tempInt];
        if(num == 2)
        {
            position.x = -176.8718f;
        }
        else if(num == 3)
        {
            position.x = -176.8718f;
        }
        else if(num == 4)
        {
            position.x = -177.1656f;
        }
        else
        {
            position.x = -177.4092f;
        }

        transform.position = position;

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            aHit = true;
        }
    }

}
