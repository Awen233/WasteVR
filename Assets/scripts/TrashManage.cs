using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashManage : MonoBehaviour
{
    List<GameObject> trashes;
    int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        trashes = new List<GameObject>();
        foreach (Transform child in transform)
        {
            trashes.Add(child.gameObject);
            child.gameObject.SetActive(false);
        }
        putOne();
    }

    public void putOne()
    {
        if(index >= trashes.Count)
        {
            return;
        }
        trashes[index].SetActive(true);
        index++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
