using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool SceneBack;

    void Start()
    {
        SceneBack = false;
    }

    public void ReturnMe()
    {
        Debug.Log("werkt het");
    }
}
