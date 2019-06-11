using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfScreen : MonoBehaviour
{

    /*void Update()
    {
        transform.Translate(movement * speed * Time.deltaTime, Space.Self);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, MIN_X, MAX_X), Mathf.Clamp(transform.position.y, MIN_Y, MAX_Y), Mathf.Clamp(transform.position.z, MIN_Z, MAX_Z));

    }

    /*public GameObject player;

    void Update()
    { 
        if (player.transform.position.x < 2)
        {
            Debug.Log("camera raakt kant links");
            Debug.Log(player.transform.position.x);
    
            transform.position = new Vector3(player.transform.position.x + 9, transform.position.y, transform.position.z);
            
        }
        else
        {
            Debug.Log("center on player plz");
            transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
            //StartCoroutine(MoveOverField());

        }
        /*IEnumerator MoveOverField()
        {
            float timer = .0f;
            while (timer < .5f)
            {
                timer += Time.deltaTime;
                transform.position += new Vector3((player.transform.position.x+9) * Time.deltaTime, transform.position.y, transform.position.z);
                yield return 0;
            }
        }*/



    /*if (transform.position.x > 74)
    {
        transform.position = new Vector3(74, transform.position.y, transform.position.z);
    }*/

//}

}
