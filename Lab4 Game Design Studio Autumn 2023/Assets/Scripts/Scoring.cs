using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  

public class scoring : MonoBehaviour
{
    public int score = 0;
    public Text Score;
    private void Update()
    {
        Score.text = "  Score : " + score;
    }
//need shooting condition

}
