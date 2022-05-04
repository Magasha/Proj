using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task2 : MonoBehaviour
{
    public int getting_toys;
    public GameObject Pyramid, ManyToys, Car, Horse, Bird;
    public Text CountToys;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pyramid")
        {
            getting_toys++;
            Destroy(Pyramid);
            CountToys.text = getting_toys.ToString();
        }
        if (other.tag == "ManyToys")
        {
            getting_toys++;
            Destroy(ManyToys);
            CountToys.text = getting_toys.ToString();
        }
        if (other.tag == "Car")
        {
            getting_toys++;
            Destroy(Car);
            CountToys.text = getting_toys.ToString();
        }
        if (other.tag == "Horse")
        {
            getting_toys++;
            Destroy(Horse);
            CountToys.text = getting_toys.ToString();
        }
        if (other.tag == "Bird")
        {
            getting_toys++;
            Destroy(Bird);
            CountToys.text = getting_toys.ToString();
        }
    }
}
