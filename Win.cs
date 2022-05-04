using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject Candle1, Candle2, Candle3, Win1, Win2, Map, Player;
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
        if (other.tag == "Altar")
        {
            Candle1.SetActive(true);
            Candle2.SetActive(true);
            Candle3.SetActive(true);
        }

        if (other.tag == "Win")
        {
            Win1.SetActive(true);
            Win2.SetActive(true);
            Map.SetActive(false);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        
    }
}
