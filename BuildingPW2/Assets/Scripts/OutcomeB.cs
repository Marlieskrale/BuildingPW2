using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutcomeB : MonoBehaviour
{
    public GameObject OutcomeBad;
    public GameObject OutcomeBadText;


    void Start()
    {
        OutcomeBad.SetActive(false);
        OutcomeBadText.SetActive(false);
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            OutcomeBadText.SetActive(true);
            //OutcomeBad.SetActive(true);

            if (Input.GetKeyDown(KeyCode.T))
            {

                Debug.Log("De keuze is T");
                OutcomeBad.SetActive(true);

            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        OutcomeBadText.SetActive(false);
    }
}
