using UnityEngine;
using System.Collections;

public class ItemLoader : MonoBehaviour {

    public const string path = "items";

    /*public string ques = "";
    public float index = -1f;
    public float choiceNum = -1f;
    public string correct = "";*/

    public static string[] quesArr = new string[10];
    public static float[] indexArr = new float[10];
    public static float[] choiceArr = new float[10];
    public static string[] correctArr = new string[10];


	// Use this for initialization
	void Start () 
    {
        ItemContainer ic = ItemContainer.Load(path);
        int counter = 0;

        foreach (Item item in ic.items)
        {
            //print(item.question);
            //print(item.indexNum);
            //print(item.choiceNum);
            //print(item.correctAnswer);
            //Debug.Log(item.question);
            quesArr[counter] = item.question;
            indexArr[counter] = item.indexNum;
            choiceArr[counter] = item.choiceNum;
            correctArr[counter++] = item.correctAnswer;
        }
	}
	
	
}
