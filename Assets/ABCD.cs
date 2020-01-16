using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ABCD : MonoBehaviour
{
    // Start is called before the first frame update

    public Text nameLable;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 namePose = Camera.main.WorldToScreenPoint(this.transform.position);
        //namePose.y = namePose.y + 5;
        if (namePose.z > 0)
        {
            //set visible
            nameLable.transform.position = namePose;
        }
        else {
            return;
        } //set invisible

    }
}
