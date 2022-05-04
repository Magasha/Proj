using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MusicOn.b){
            AudioListener.volume = 0.45f;
        }
        else
            AudioListener.volume = 0;
    }
}
