using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMain : MonoBehaviour
{
    [SerializeField] private Transform Player;
    //[SerializeField] private Transform BackToMainLevel;
    public GameObject GM;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("trigger main level");
            SceneManager.LoadScene("Level");
            //Player.transform.position = BackToMainLevel.transform.position;
            Player.transform.position = new Vector3(148, 3, 0);
        }

    }

}