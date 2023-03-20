using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public Scoring scoring;
    public Text winning;
    private GameObject win;

    private void Awake()
    {
        win = GameObject.FindWithTag("Win");
    }
    void Start()
    {
        win.SetActive(false);
    }

    void ///
    {
        if (//win condition)
       {
         winning.text = "You Win!" + "\n" + "\n" + "Your Score is " + scoring.score + "\n" + "\n" + "Go to next level after 5 seconds";
         win.SetActive(true);
        }
    }
