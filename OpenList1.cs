using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenList1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject List, Point;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "List1")
        {
            List.SetActive(true);
            Point.SetActive(false);

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "List1")
        {
            List.SetActive(false);
        }
    }
}
