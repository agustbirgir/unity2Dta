using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) // þetta er stiga system fyrir leikinn
    {
        if(collision.collider.tag == "Player")
        {
            KeepScore.Score += 1;
            Destroy(gameObject);
            
        }
    }

    
}   


