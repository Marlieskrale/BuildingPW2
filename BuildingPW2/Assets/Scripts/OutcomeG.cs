using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutcomeG : MonoBehaviour
{
    public GameObject OutcomeGood;
    public GameObject OutcomeGoodText;


    void Start()
    {
        OutcomeGood.SetActive(false);
        OutcomeGoodText.SetActive(false);
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            OutcomeGoodText.SetActive(true);
            //OutcomeGood.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("De keuze is E");
                OutcomeGood.SetActive(true);

            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        OutcomeGoodText.SetActive(false);
    }
}
