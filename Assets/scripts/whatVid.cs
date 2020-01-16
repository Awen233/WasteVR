using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whatVid : MonoBehaviour
{
    public Material[] videoThumb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void currentVid(int i)
    {
        var mats= GetComponent<MeshRenderer>();

        mats.material = videoThumb[i];
       
    }

}
