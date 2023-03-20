using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    private float speed = 4f;
    private Vector3 move;
    Animator anim;
    public int ammo = 15;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            anim.SetBool("Hit", false);
            move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
            transform.position += move * speed * Time.deltaTime;
            if (Input.GetKeyDown("space"))
            {
                anim.Play("Shoot");
                ammo -= 1;
            }
        }

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
    }
}