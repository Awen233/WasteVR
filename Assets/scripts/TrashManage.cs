using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashManage : MonoBehaviour
{
    List<GameObject> trashes;
    int index = 0;
    [SerializeField] float speed = 5.0f;
    [SerializeField] Vector3 targetPosition;
    Vector3 initialPosition;
    Vector3 origin;
    int current;
    bool update;

    // Start is called before the first frame update
    void Start()
    {
        trashes = new List<GameObject>();
        origin = transform.position;
        foreach (Transform child in transform)
        {
            trashes.Add(child.gameObject);
            child.gameObject.SetActive(false);
        }
        
        putOne();
    }

    public void putOne()
    {
        if(index != 0)
        {
            trashes[index - 1].SetActive(false);
        } 
        if (index >= trashes.Count)
        {
            return;
        }
        update = true;
        trashes[index].SetActive(true);
        initialPosition = trashes[index].transform.position;
        print(initialPosition);
        current = index;
        index++;
    }

    // Update is called once per frame
    void Update()
    {
        print(update);
        if(initialPosition.magnitude - (targetPosition + origin).magnitude <= 0.01)
        {
            update = false;
        }
        if (update)
        {
            trashes[current].transform.position = Vector3.MoveTowards(initialPosition, targetPosition + origin, Time.deltaTime * speed);
            initialPosition = trashes[current].transform.position;
        }
        
    }

    public Vector3 getInitial()
    {
        return targetPosition + origin;
    }
}
