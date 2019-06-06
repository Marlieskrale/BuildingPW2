using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D KapowOnwardsToTheCave)
    {

        if (KapowOnwardsToTheCave.gameObject.tag == "Player")
        {
            Debug.Log("trigger level02");
            SceneManager.LoadScene("Level02");
        }

    }

}