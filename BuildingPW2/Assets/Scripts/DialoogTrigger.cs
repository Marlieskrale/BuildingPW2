using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoogTrigger : MonoBehaviour
{
    public GameObject uiDialoog;


    void Start()
    {
        uiDialoog.SetActive(false);
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Dialoog1 van Henkie");
            uiDialoog.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Geen dialoog");
        uiDialoog.SetActive(false);
    }

}
