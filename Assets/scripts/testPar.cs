using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testPar : MonoBehaviour
{

    [SerializeField] ParticleSystem pe;

    // Start is called before the first frame update
    void Start()
    {
        ParticleSystem.MainModule main = pe.main;
        main.startLifetime = 1.0f;
        pe.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playParticle()
    {
        print("playParticle() called");
        pe.Play();
    }
}
