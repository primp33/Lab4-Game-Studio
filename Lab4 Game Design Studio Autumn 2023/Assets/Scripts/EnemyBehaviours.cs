using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviours : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.5f;

    Rigidbody2D myRigidbody;

    private void OnBecameVisible()
    {
        enabled = true;
    }

    private void OnBecameInvisible()
    {
        enabled = false;
    }
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //if(IsFacingRight())
        //{
        myRigidbody.velocity = transform.right * moveSpeed;
        //} else
        //{
        //    myRigidbody.velocity = new Vector2(-moveSpeed, 0f);
        //}
    }

    //private bool IsFacingRight()
    //{
    //    return transform.localScale.x > Mathf.Epsilon;
    //}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.name == "wall")
        {
            //transform.localScale = new Vector2(-((myRigidbody.velocity.x)), transform.localScale.y);
            moveSpeed = -moveSpeed;
        }
    }

}
