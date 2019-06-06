using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choice : MonoBehaviour
{

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {

            Debug.Log("De keuze is E");

        }

        if (Input.GetKeyDown(KeyCode.T))
        {

            Debug.Log("De keuze is T");

        }

    }
}
