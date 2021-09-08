using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver2 : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    /*
    private void OnCollisionEnter(Collision collision)
    {
        KeepScore.Score = 0;
        Debug.Log("Aftur");
    }
    */
    void OnCollisionEnter(Collision collision)
    {


        if (collision.collider.tag == "Player")
        {
            KeepScore.Score = 0;
            Debug.Log("Aftur");


            SceneManager.LoadScene(2);
            Debug.Log("crashed fool");

        }
        // SceneManager.LoadScene(1);
        // Debug.Log("crashed fool") ;

    }
}
