using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraReleaseTrigger : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "CameraReleaseTrigger")
        {
            Debug.Log("Camera stopt met meelopen");
            GameObject.Find("Main Camera").transform.parent = null;
        }

    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("camera is a free bird");
        GameObject.Find("Main Camera").transform.parent = player.transform;
    }
}
