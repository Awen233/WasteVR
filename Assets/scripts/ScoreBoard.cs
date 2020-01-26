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
        attempts = 0;
        failTime = 0;
        sortedTrash = 0;
        //unsortedTrash = 5;
    }

    public void PutCorrect()
    {
        print("inside put Correct");
        print("aatempts " + attempts);
        attempts++;
        print("sorted " + sortedTrash);
        sortedTrash++;
        print("unsorted trash " + unsortedTrash);
        unsortedTrash -= 1;
        print("unsorted trash after -- " + unsortedTrash);
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

    public void SetText()
    {
        float rate = CalculateSuccessRate();

        print("inside set Text ");
        print("unsorted trash " + unsortedTrash);

        text.text =
            "success rate: " + rate + "\n"
            + "number of times failure: " + failTime + "\n"
            + "number of unsorted trash: " + unsortedTrash + "\n"
            + "number of sorted trash: " + sortedTrash;
    }
}
