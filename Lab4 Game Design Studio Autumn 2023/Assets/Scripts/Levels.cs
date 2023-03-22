using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Levels : MonoBehaviour
{
    public Controller controller;
    public ShootEffect shooteffect;
    private int level = 1;
    private GameObject win;
    private GameObject lose;
    public Text Ammo;
    public Text Time;
    public Text losing;
    public Text winning;
    public GameObject life1, life2, life3;
    private int life = 3;
    private int time = 120;
    private GameObject player;
    //NEED TO ADD COUNTDOWN TIMER
    //LOSE A LIFE EVERYTIME TIME IS ZERO

    // Start is called before the first frame update
    private void Awake()
    {
        win = GameObject.FindWithTag("Win");
        lose = GameObject.FindWithTag("Lose");
    }
    void Start()
    {
        win.SetActive(false);
        lose.SetActive(false);
        losing = GetComponent<Text>();
        player = GameObject.Find("Player Sprite");
    }

    // Update is called once per frame
    void Update()
    {
        Ammo.text = "Ammo: " + controller.ammo;

        if (controller.ammo == 0 || life == 0)
        {
            lose.SetActive(true);
            losing.text = "You Lose!" + "\n" + "\n" + "Level "+ level + "   Enemies Left : " + controller.enemiesLeft + "\n" + "\n" + "Press 'R' to Restart";
            //stop timer
        }
        if (time == 0)
        {
            life -= 1;
        }
        if (controller.enemiesLeft == 0)
        {
            controller.ammo = 15;

            if (level == 3)
            {
                winning.text = "You Win!";
                win.SetActive(true);
                //stop timer
            }
            level += 1;
        }
        if (level == 2)
        {
            transform.position = new Vector3(0, 12,-10);
            player.transform.position = new Vector3(0, 12, player.transform.position.z);
            controller.enemiesLeft = 7;
            time = 150;
        }
        if (level == 3)
        {
            transform.position = new Vector3(0, 24,-10);
            player.transform.position = new Vector3(0, 23, player.transform.position.z);
            controller.enemiesLeft = 10;
            time = 180;
        }

    }
    //void life()
    //{
    //    if (life == 3)
    //    {
    //        life3.SetActive(true);
    //        life2.SetActive(true);
    //        life1.SetActive(true);
    //    }
    //    if (life == 2)
    //    {
    //        life3.SetActive(false);
    //    }
    //    if (life == 1)
    //    {
    //        life2.SetActive(false);
    //    }
    //    if (life < 1)
    //    {
    //        life1.SetActive(false);
    //    }
    //}
}
