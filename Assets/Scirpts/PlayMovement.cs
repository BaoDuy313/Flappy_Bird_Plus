using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float bounceForce;
    public float sideForce;
    public bool turnLeft = false;
    public bool turnRight = true;

    private Animator anim;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Start()
    {
        rb.isKinematic = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 temp = transform.localScale;
        if (turnLeft==true)
        {
            temp.x = -1f;
        }
        if (turnRight==true)
        {
            temp.x = 1f;
        }
        transform.localScale = temp;
    }
    public void BirdMovement()
    {
        rb.velocity = new Vector2(sideForce, bounceForce);
    }
   
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "pipeLeft")
        {
            Debug.Log("right....");
            sideForce = -sideForce;
            turnLeft = false;
            turnRight = true;
        }
        if (collision.collider.tag == "pipeRight")
        {
            Debug.Log("left....");
            sideForce = -sideForce;
            turnLeft = true;
            turnRight = false;
        }
    }

}
