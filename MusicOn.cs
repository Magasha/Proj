using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOn : MonoBehaviour
{
    public GameObject On, Off;
    int count = 0;
    public static bool b = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count % 2 == 0 && Input.GetKeyDown(KeyCode.M))
        {
            count++;
            Off.SetActive(true);
            On.SetActive(false);
            b = false;
        }
        else if (count % 2 != 0 && Input.GetKeyDown(KeyCode.M))
        {
            count++;
            On.SetActive(true);
            Off.SetActive(false);
            b = true;
        }
    }
    public void Music()
    {
        count++;
        if (count % 2 == 0 && Input.GetKey(KeyCode.M))
        {
            Off.SetActive(true);
            On.SetActive(false);
            b = false;
        }
        else if (count % 2 != 0 && Input.GetKey(KeyCode.M))
        {
            On.SetActive(true);
            Off.SetActive(false);
            b = true;
        }
    }
}
