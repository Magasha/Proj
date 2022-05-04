using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    public Animator animDoor, animDoor2;
    public GameObject List3, Point;
    public AudioSource Diary;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "VillaDoor")
        {
            animDoor.SetTrigger("open2");
            animDoor2.SetTrigger("closedoor2");
            Point.SetActive(false);
        }
        if (other.tag == "List3")
        {
            Diary.Play();
        }
    }
}
