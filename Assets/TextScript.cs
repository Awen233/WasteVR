using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public Text Quiz;

    // Update is called once per frame
    void Update()
    {
        Vector3 Position = transform.position;
        Position.z = Position.z - 1f;
        Quiz.transform.position = Position;
    }
}
