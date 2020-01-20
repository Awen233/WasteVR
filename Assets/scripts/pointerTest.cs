using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointerTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter()
    {
        gameObject.SetActive(false);
    }
}
