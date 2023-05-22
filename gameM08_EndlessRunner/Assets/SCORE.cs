using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCORE : MonoBehaviour
{

    public int score;
    public Text punt;
    private void Update()
    {
        punt.text = score.ToString();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("muro"))
        {
            score++;
            Debug.Log(punt);
        }
    }
}
