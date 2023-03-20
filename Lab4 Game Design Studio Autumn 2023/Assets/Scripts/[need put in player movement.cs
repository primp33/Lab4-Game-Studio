//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.SceneManagement;

//public class [needputinplayermovement: MonoBehaviour
//{
//    public GameObject ammo1, ammo2, ammo3, ammo4, ammo5, ammo6, ammo7;
//    public GameObject life1, life2, life3;
//    private int life = 3;
//    private GameObject lose;
//    public Text losing;
//    private int ammo = 7; 

////need to do the be attacked part
////if be attacked
////life--;
////life();
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
//        life2.SetActive(true);
//        life1.SetActive(true);
//    }
//    if (life == 1)
//    {
//        life3.SetActive(false);
//        life2.SetActive(false);
//        life1.SetActive(true);
//    }
//    if (life < 1)
//    {
//        life3.SetActive(false);
//        life2.SetActive(false);
//        life1.SetActive(false);
//        //lose game 
//        LoseGame();
//    }
//}

////need to do the attack part
////if attack
////ammo--;
////ammo();
//void ammo()
//{
//    if (ammo == 7)
//    {
//        ammo7.SetActive(true);
//        ammo6.SetActive(true); 
//        ammo5.SetActive(true); 
//        ammo4.SetActive(true); 
//        ammo3.SetActive(true); 
//        ammo2.SetActive(true); 
//        ammo1.SetActive(true);
//    }
//    if (ammo == 6)
//    {
//        ammo7.SetActive(false);
//        ammo6.SetActive(true);
//        ammo5.SetActive(true);
//        ammo4.SetActive(true);
//        ammo3.SetActive(true);
//        ammo2.SetActive(true);
//        ammo1.SetActive(true);
//    }
//    if (ammo == 5)
//    {
//        ammo7.SetActive(false);
//        ammo6.SetActive(false);
//        ammo5.SetActive(true);
//        ammo4.SetActive(true);
//        ammo3.SetActive(true);
//        ammo2.SetActive(true);
//        ammo1.SetActive(true);
//    }
//    if (ammo == 4)
//    {
//        ammo7.SetActive(false);
//        ammo6.SetActive(false);
//        ammo5.SetActive(false);
//        ammo4.SetActive(true);
//        ammo3.SetActive(true);
//        ammo2.SetActive(true);
//        ammo1.SetActive(true);
//    }
//    if (ammo == 3)
//    {
//        ammo7.SetActive(false);
//        ammo6.SetActive(false);
//        ammo5.SetActive(false);
//        ammo4.SetActive(false);
//        ammo3.SetActive(true);
//        ammo2.SetActive(true);
//        ammo1.SetActive(true);
//    }
//    if (ammo == 2)
//    {
//        ammo7.SetActive(false);
//        ammo6.SetActive(false);
//        ammo5.SetActive(false);
//        ammo4.SetActive(false);
//        ammo3.SetActive(false);
//        ammo2.SetActive(true);
//        ammo1.SetActive(true);
//    }
//    if (ammo == 1)
//    {
//        ammo7.SetActive(false);
//        ammo6.SetActive(false);
//        ammo5.SetActive(false);
//        ammo4.SetActive(false);
//        ammo3.SetActive(false);
//        ammo2.SetActive(false);
//        ammo1.SetActive(true);
//    }
//    if (ammo < 1)
//    {
//        ammo7.SetActive(false);
//        ammo6.SetActive(false);
//        ammo5.SetActive(false);
//        ammo4.SetActive(false);
//        ammo3.SetActive(false);
//        ammo2.SetActive(false);
//        ammo1.SetActive(false);
//        //lose game 
//        LoseGame();
//    }
//}

//private void Awake()
//{
//    lose = GameObject.FindWithTag("lose");

//void Start()
//    {
//        lose.SetActive(false);
//    }

// void LoseGame()
//    {
//        if (life < 1)
//        {
//            losing.text = "You Lose!" + "\n" + "\n" + "Your Score is " + scoring.score + "\n" + "\n" + "Restart after 5 seconds.";
//            Lose.SetActive(true);
//            Invoke("Restart", 5s);
//        }
//    }
//}