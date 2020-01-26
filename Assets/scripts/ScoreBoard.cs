using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    int attempts;
    int failTime;
    public int unsortedTrash;
    int sortedTrash;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PutCorrect()
    {
        attempts++;
        sortedTrash++;
        unsortedTrash -= 1;
        SetText();
    }

    public void PutWrong()
    {
        attempts++;
        failTime++;
        SetText();
    }

    private float CalculateSuccessRate()
    {
        if(attempts == 0)
        {
            return 0.0f;
        }
        return ((float)sortedTrash)/attempts;
    }

    public void SetText()
    {
        float rate = CalculateSuccessRate();



        text.text =
            "success rate: " + rate + "\n"
            + "number of times failure: " + failTime + "\n"
            + "number of unsorted trash: " + unsortedTrash + "\n"
            + "number of sorted trash: " + sortedTrash;
    }
}
