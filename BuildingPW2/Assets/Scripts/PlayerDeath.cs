using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public GameObject PlayerDeathUI;


    void Start()
    {
        PlayerDeathUI.SetActive(false);
    }

    IEnumerator PlayerPause()
    {
        Debug.Log("u ded");
        PlayerDeathUI.SetActive(true);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Level");
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(PlayerPause());
        }
    }

}