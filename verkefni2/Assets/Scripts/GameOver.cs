using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        KeepScore.Score = 0;
        Debug.Log("Aftur");
    }
    
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(1);
        Debug.Log("crashed");
    }
    
}
