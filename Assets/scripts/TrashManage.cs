using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrashManage : MonoBehaviour
{
    List<GameObject> trashes;
    int index = -1;
    [SerializeField] float speed = 5.0f;
    Vector3 targetPosition;
    Vector3 initialPosition;
    //Vector3 origin;
    int current;
    bool update;
    int distance = 2;
    Vector3 currentPosition;


    public AudioClip successAudio;
    public AudioClip failAudio;
    AudioSource audioSource;

    ScoreBoard scoreBoard;

    // Start is called before the first frame update
    void Start()
    {
        print("hello world");

        audioSource = GetComponent<AudioSource>();
        trashes = new List<GameObject>();
        //origin = transform.position;
        foreach (Transform child in transform)
        {
            trashes.Add(child.gameObject);
            child.gameObject.SetActive(false);
        }
        Randomization();
        SetScoreBoard();
        PutOne();
        //InvoteMethod();
    }

    public void PutOne()
    {
        //if(index != 0)
        //{
        //    trashes[index - 1].SetActive(false);
        //}
        index++;
        if (index >= trashes.Count - 1)
        {
            trashes[index].SetActive(true);
            return;
        }
        
        trashes[index].SetActive(true);
        Invoke("StartMoving", 1);
        
    }

    void StartMoving()
    {
        update = true;
        initialPosition = trashes[index].transform.position;
        targetPosition = new Vector3(initialPosition.x + 1.8f, initialPosition.y, initialPosition.z);
        //print("first initial positions: " + initialPosition);
        //print("last target positions: " + targetPosition);

        current = index;
        currentPosition = trashes[current].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(update == false)
        {
            return;
        }
        if (currentPosition.magnitude - targetPosition.magnitude <= 0.01)
        {
            update = false;
        }
        if (update)
        {
            currentPosition = Vector3.MoveTowards(currentPosition, targetPosition, Time.deltaTime * speed);
            trashes[current].transform.position = currentPosition;
        }
    }

    public void InvoteMethod()
    {
        Invoke("PutCorrect", 5);
    }

    public Vector3 getInitial()
    {
        return targetPosition;
    }

    void Randomization()
    {
        for(int i = 0; i < trashes.Count - 1; i++)
        {
            int randomIndex = Random.Range(i, trashes.Count - 1);
            GameObject temp = trashes[i];
            trashes[i] = trashes[randomIndex];
            trashes[randomIndex] = temp;
        }       
    }

    public int GetNumberOfTrash()
    {
        return trashes.Count - 1; 
    }

    public void PlaySuccessAudio()
    {
        audioSource.PlayOneShot(successAudio, 1.0f);
    }

    public void playFailAudio()
    {
        audioSource.PlayOneShot(failAudio, 1.0f);
    }


    public void SetScoreBoard()
    {
        trashes[trashes.Count - 1].SetActive(true);
        scoreBoard = trashes[trashes.Count - 1].GetComponent<ScoreBoard>();
        scoreBoard.unsortedTrash = trashes.Count - 1;
        scoreBoard.SetText();
    }

    public void PutWrong()
    {
        scoreBoard.PutWrong();
        playFailAudio();
    }

    public void PutCorrect()
    {
        scoreBoard.PutCorrect();
        PlaySuccessAudio();
    }
}
