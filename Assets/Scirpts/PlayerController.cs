using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.tag == "thorn"|| collision.collider.tag == "saw")
        {
            Debug.Log("Hit....");
            FindObjectOfType<GameManager>().IsDead = true;
        }
    }
}
