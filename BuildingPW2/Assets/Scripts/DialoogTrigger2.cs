using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoogTrigger2 : MonoBehaviour
{
    public GameObject uiDialoog2;


    void Start()
    {
        uiDialoog2.SetActive(false);
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Dialoog van Pieter");
            uiDialoog2.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        uiDialoog2.SetActive(false);
    }

}
