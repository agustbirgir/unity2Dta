using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
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

    // �etta er collider �egar eg deyr og resetar stiginn
    void OnCollisionEnter(Collision collision)
    {
         
        
        if (collision.collider.tag == "Player")
        {
            KeepScore.Score = 0;
            Debug.Log("Aftur");


            SceneManager.LoadScene(1);
            Debug.Log("crashed fool");

        }
        // SceneManager.LoadScene(1);
        // Debug.Log("crashed fool") ;

    }
    
}
