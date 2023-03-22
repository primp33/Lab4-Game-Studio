using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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
    public Text timeText;
    public Text losing;
    public Text winning;
    public GameObject[] lives;
    private int life = 3;
    private List<float> timeleft = new List<float>() { 60, 70, 80, 0};
    public float current;
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
        losing = lose.GetComponent<Text>();
        player = GameObject.Find("Player Sprite");
        current = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (!(level == 4))
        {
        current -= Time.deltaTime;
        }
        timeText.text = "Timer: " + (int)current +"s";

        Ammo.text = "Ammo: " + controller.ammo;

        if (controller.ammo == 0 || life == 0)
        {
            lose.SetActive(true);
            losing.text = "You Lose!" + "\n" + "\n" + "Level "+ level + "   Enemies Left : " + controller.enemiesLeft + "\n" + "\n" + "Press 'R' to Restart";
            Time.timeScale = 0;
        }
        if (current < 0)
        {
            life -= 1;
            lives[life].SetActive(false);
            current = timeleft[level-1];
        }
        if (controller.enemiesLeft == 0 && !(level == 4))
        {
            controller.ammo = 15;

            level += 1;
            current = timeleft[level - 1];

        if (level == 2)
        {
            transform.position = new Vector3(0, 12,-10);
            player.transform.position = new Vector3(0, 12, player.transform.position.z);
            controller.enemiesLeft = 7;
                controller.ammo = 20;
        }
        if (level == 3)
        {
            transform.position = new Vector3(0, 24,-10);
            player.transform.position = new Vector3(0, 23, player.transform.position.z);
            controller.enemiesLeft = 10;
                controller.ammo = 25;
        }
            if (level == 4)
            {
                winning.text = "You Win!";
                win.SetActive(true);
                Time.timeScale = 0;
                //stop timer
            }

        }
    }
    //void life()
    //{
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
