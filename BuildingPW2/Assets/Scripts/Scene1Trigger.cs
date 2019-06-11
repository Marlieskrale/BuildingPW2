using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1Trigger : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D BackToMainLevel)
    {

        if (BackToMainLevel.gameObject.tag == "Player")
        {
            Debug.Log("trigger main level");
            SceneManager.LoadScene("Level");
        }

    }

}