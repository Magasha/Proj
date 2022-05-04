using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenBook : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Book, Book1, Book2;
    public int countI = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && countI % 2 == 0)
        {
            countI ++;
            Book.SetActive(true);
            Time.timeScale = 0f;

        }

        else if (Input.GetKeyDown(KeyCode.I) && countI % 2 == 1)
        {
            countI ++;
            Book.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Book1.SetActive(false);
            Book2.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Book2.SetActive(false);
            Book1.SetActive(true);
        }
    }
}
