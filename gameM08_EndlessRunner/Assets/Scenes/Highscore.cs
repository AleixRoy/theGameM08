using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public int score;
    public Text scoreC;

     void Start()
    {
        
    }
    public void AddScoreButton()
    {
        score += 1;
    }
}
