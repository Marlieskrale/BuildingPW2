using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    private void Awake()
    {
        //Cursor.visible;
        Cursor.lockState = CursorLockMode.None;

    }

    public void PlayGame ()
    {
        
        SceneManager.LoadScene("Intro");
        Debug.Log("start");

    }

    public void StartLevel ()
    {

        SceneManager.LoadScene("Level");
        Debug.Log("startLevel");

    }

    public void QuitGame ()
    {

        Application.Quit();
        Debug.Log("quit");

    }
}
