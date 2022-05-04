using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PickUp : MonoBehaviour
{
    
    public Text CountKeys;
    public Collider col;
    public Animator anim,carpetAnim;
    public GameObject Key1, Key2, Enemy;
    public GameObject Boat, List;
    public bool IsDoor, Carpet;
    public int getting_key;
    void Update()
    {
        if (getting_key >= 1)
        {
            Destroy(Key1);
        }
        if (getting_key == 2)
        {
            Destroy(Key2);
            Enemy.SetActive(true);
        }
        if (IsDoor)
        {
            if (getting_key == 1)
            {

                if (Input.GetKey(KeyCode.E))
                {
                    anim.SetTrigger("open");
                }
            }
        }
        if (getting_key == 2 && Input.GetKey(KeyCode.E) && Carpet)
        {
            List.SetActive(true);
            carpetAnim.SetTrigger("moving");
            col.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
        {
            getting_key += 1;
            CountKeys.text = getting_key.ToString();
          
        }
        if (other.tag == "Door")
        {
            IsDoor = true;
        }
        if (other.tag == "Carpet")
        {
            Carpet = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Door")
        {
            IsDoor = false;
        }
    }
}
