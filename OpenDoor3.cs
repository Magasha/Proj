using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor3 : MonoBehaviour
{
    public Animator Anim1, Anim2;
    public GameObject Book, Ready;
    public bool door = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MoveKeyDasha.Dasha && MoveKeyMasha.Masha && MoveKeyAnya.Anya && MoveKeyOlya.Olya)
        {
            Book.SetActive(true);
        }
        if (door) 
        {
            Anim1.SetTrigger("open");
            Anim2.SetTrigger("open");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Book3")
        {
            door = true;
            Destroy(Book);
            Ready.SetActive(true);
        }
    }
}
