using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrashManage : MonoBehaviour
{
    List<GameObject> trashes;
    int index = 0;
    [SerializeField] float speed = 5.0f;
    [SerializeField] Vector3 targetPosition;
    Vector3 initialPosition;
    Vector3 origin;
    int current;
    bool update;

    public AudioClip successAudio;
    public AudioClip failAudio;
    AudioSource audioSource;

    ScoreBoard scoreBoard;

    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(1);


        print("hello world");

        audioSource = GetComponent<AudioSource>();
        trashes = new List<GameObject>();
        origin = transform.position;
        foreach (Transform child in transform)
        {
            trashes.Add(child.gameObject);
            child.gameObject.SetActive(false);
        }
        Randomization();
        SetScoreBoard();
        PutOne();
    }

    public void PutOne()
    {
        //if(index != 0)
        //{
        //    trashes[index - 1].SetActive(false);
        //}
        if (index >= trashes.Count - 1)
        {
            trashes[index].SetActive(true);
            return;
        }
        update = true;
        trashes[index].SetActive(true);
        initialPosition = trashes[index].transform.position;
        current = index;
        index++;
    }

    // Update is called once per frame
    void Update()
    {
        if(initialPosition.magnitude - (targetPosition + origin).magnitude <= 0.01)
        {
            update = false;
        }
        if (update)
        {
            trashes[current].transform.position = Vector3.MoveTowards(initialPosition, targetPosition + origin, Time.deltaTime * speed);
            initialPosition = trashes[current].transform.position;
        }
    }

    public Vector3 getInitial()
    {
        return targetPosition + origin;
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
        scoreBoard.SetNumberOfTrashes(trashes.Count - 1);
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
