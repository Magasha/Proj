using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour
{
    int count = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            count++;
            if (count % 2 == 0)
            {
                GetComponent<Light>().intensity = 1;
            }
            else
            {
                GetComponent<Light>().intensity = 0;
            }
        }
    }
}
