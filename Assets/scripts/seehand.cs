using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seehand : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
       gameObject.GetComponent<SkinnedMeshRenderer>().enabled = true;
        Debug.Log("hand true");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<SkinnedMeshRenderer>().enabled = true;
    }
}
