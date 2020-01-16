using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    int attempts;
    int failTime;
    int unsortedTrash;
    int sortedTrash;
    [SerializeField] Text text;

    // Start is called before the first frame update
    void Start()
    {
        attempts = 0;
        failTime = 0;
        unsortedTrash = 0;
        sortedTrash = 0;
    }

    public void PutCorrect()
    {
        attempts++;
        sortedTrash++;
        unsortedTrash--;
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
        return sortedTrash / attempts;
    }

    public void SetNumberOfTrashes(int num)
    {
        unsortedTrash = num;
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
