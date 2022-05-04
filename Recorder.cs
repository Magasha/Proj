using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recorder : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource Note, Mus;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Recorder")
        {
            Note.Play();
            Mus.volume = 0.15f;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Recorder")
        {
            Mus.volume = 0.45f;
        }
    }
}
