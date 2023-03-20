using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEffect : MonoBehaviour
{
    private Animator anim;
    private GameObject player;
    public int enemiesLeft = 9;

    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.Find("Player Sprite");
        anim = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    }
        private void OnTriggerEnter2D(Collider2D collision)
        {
        if (!collision.gameObject.CompareTag("Wall"))
        {
        if ((collision.gameObject.CompareTag("Enemy"))&&(anim.GetBool("Hit")==false))
        {
            anim.SetBool("Hit", true);
            collision.gameObject.SetActive(false);
            enemiesLeft -= 1;
        }
        }

    }
}
