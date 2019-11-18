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
        randomization();
        putOne();
    }

    public void putOne()
    {
        print("started");
        //if(index != 0)
        //{
        //    trashes[index - 1].SetActive(false);
        //}
        print(index >= trashes.Count);
        if (index >= trashes.Count - 1)
        {
            trashes[index].SetActive(true);
            return;
        }
        update = true;
        trashes[index].SetActive(true);
        initialPosition = trashes[index].transform.position;

        current = index;
        index++;
    }

    // Update is called once per frame
    void Update()
    {
   //     print(update);
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

    void randomization()
    {
        for(int i = 0; i < trashes.Count - 1; i++)
        {
            int randomIndex = Random.Range(i, trashes.Count - 1);
            GameObject temp = trashes[i];
            trashes[i] = trashes[randomIndex];
            trashes[randomIndex] = temp;
        }       
    }
}
