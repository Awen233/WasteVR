using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TMPtezt : MonoBehaviour
{
    private TMP_Text texObj;

    void Start()
    {
        texObj = GetComponent<TMP_Text>();
        texObj.text = "Show me";


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
