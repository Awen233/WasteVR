using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;
    [SerializeField] Vector3 targetPosition;
    Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(initialPosition, targetPosition, Time.deltaTime  * speed);
        print(transform.position);
        initialPosition = transform.position;
    }
}
