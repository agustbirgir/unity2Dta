using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour
{
    // me� �essu ko�a er eg bara a� setja upp n�sta scenu
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(2);
    }
}
