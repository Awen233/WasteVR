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
    public Text unsortedText;
    public Text sortedText;
    public Text failTimeText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PutCorrect()
    {
        attempts++;
        sortedTrash++;
        SetSortedText();
        unsortedTrash -= 1;
        SetUnsortedText();
    }

    public void PutWrong()
    {
        attempts++;
        failTime++;
        SetFailTimeText();
    }

    private float CalculateSuccessRate()
    {
        if(attempts == 0)
        {
            return 0.0f;
        }
        return ((float)sortedTrash)/attempts;
    }

    public void SetUnsortedText()
    {
        float rate = CalculateSuccessRate();

        unsortedText.text = unsortedTrash.ToString();

        /*text.text =
            "success rate: " + rate + "\n"
            + "number of times failure: " + failTime + "\n"
            + "number of unsorted trash: " + unsortedTrash + "\n"
            + "number of sorted trash: " + sortedTrash;
        */
    }

    public void SetSortedText()
    {
        sortedText.text = sortedTrash.ToString();
    }

    public void SetFailTimeText()
    {
        failTimeText.text = failTime.ToString();
    }
}
