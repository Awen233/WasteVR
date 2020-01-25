using UnityEngine;
using System.Collections;

public class ItemLoader : MonoBehaviour {

    public const string path = "items";

    public const int numSize = 10;//modify this when modifying the number of questions

    public static string[] quesArr = new string[numSize];
    public static float[] indexArr = new float[numSize];
    public static float[] choiceArr = new float[numSize];
    public static string[] correctArr = new string[numSize];
    public static string[] a = new string[numSize];
    public static string[] b = new string[numSize];
    public static string[] c = new string[numSize];
    public static string[] d = new string[numSize];
    public static string[] e = new string[numSize];


	void Start () 
    {
        ItemContainer ic = ItemContainer.Load(path);
        int counter = 0;

        foreach (Item item in ic.items)
        {
            a[counter] = item.a;
            b[counter] = item.b;
            c[counter] = item.c;
            d[counter] = item.d;
            e[counter] = item.e;

            quesArr[counter] = item.question;
            indexArr[counter] = item.indexNum;
            choiceArr[counter] = item.choiceNum;
            correctArr[counter++] = item.correctAnswer;
        }
	}
	
	
}
