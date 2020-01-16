using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    TMP_Text instruction;
    private static string tempText;
    public static int tempInt = 0;
    public static string correct = "";
    public static string input = "";
    private string temp = "";
    public static bool callState = false;
    private const int arrVolume = 10;
    private bool[] answeredArr = new bool[arrVolume];
    private int[] userInput = new int[arrVolume];

    AudioSource audioSource;
    [SerializeField] AudioClip yes;
    [SerializeField] AudioClip no;
    [SerializeField] ParticleSystem Win = default;
    [SerializeField] ParticleSystem Lose = default;
    [SerializeField] float Delay = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InitializeAnswerArr();
        instruction = GetComponent<TMP_Text>();
        audioSource = GetComponent<AudioSource>();
        GetRandomInt();
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeText();
        if (!callState)
        {
            getKeys();
        }
    }

    private void checkPool()
    {
        int counter = 0;

        foreach(bool check in answeredArr)
        {
            if(check == true)
            {
                counter++;
            }
        }

        //initialize
        if(counter == 10)
        {
            InitializeAnswerArr();
        }
    }

    private void InitializeAnswerArr()
    {
        for (int i = 0; i < arrVolume; ++i)
        {
            answeredArr[i] = false;
        }
    }

    private void InitializeInputArr()
    {
        for (int i = 0; i < arrVolume; ++i)
        {
            userInput[i] = -1;
        }
    }

    public void GetRandomInt()
    {
        checkPool();
        PosA.aHit = false;
        PosB.bHit = false;
        PosC.cHit = false;
        PosD.dHit = false;
        PosE.eHit = false;

        bool flag = false;
        while (!flag)
        {
            tempInt = Random.Range(0, 10);
            if (!answeredArr[tempInt])
            {
                flag = true;
                answeredArr[tempInt] = true;
            }
        }

        Debug.Log("taken: " + tempInt);
        input = "";
        callState = false;
    }

    private void ChangeText()
    {
        correct = ItemLoader.correctArr[tempInt];
        tempText = ItemLoader.quesArr[tempInt];
        instruction.text = tempText;
    }

    private void getKeys()
    {
        if (callState == false)
        {
            if (Input.GetKey(KeyCode.A)||PosA.aHit)
            {
                temp = "a";
                compareKeys();
            }
            else if (Input.GetKey(KeyCode.B) || PosB.bHit)
            {
                temp = "b";
                compareKeys();

            }
            else if (Input.GetKey(KeyCode.C) || PosC.cHit && ItemLoader.choiceArr[text.tempInt] > 2)
            {
                temp = "c";
                compareKeys();

            }
            else if (Input.GetKey(KeyCode.D) || PosD.dHit && ItemLoader.choiceArr[text.tempInt] > 3)
            {
                temp = "d";
                compareKeys();

            }
            else if (Input.GetKey(KeyCode.E) || PosE.eHit && ItemLoader.choiceArr[text.tempInt] > 4)
            {
                temp = "e";
                compareKeys();
            }
            temp = "";
        }
    }

    private void compareKeys()
    {
        if (correct.CompareTo(temp) == 0)
        {
            callState = true;
            Win.Play();
            audioSource.PlayOneShot(yes);
            userInput[tempInt] = 1;
        }
        else
        {
            callState = true;
            Lose.Play();
            audioSource.PlayOneShot(no);
            userInput[tempInt] = 0;
        }
        Invoke("GetRandomInt", 3f);
    }
  
}
