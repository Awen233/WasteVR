using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickA : MonoBehaviour
{
    public Button buttonA;
    // Start is called before the first frame update
    void Start()
    {
       buttonA = GetComponent<Button>();
       buttonA.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
    }
}
