using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemaR : MonoBehaviour
{
    public GameObject scoreText;
    public int scoree;


    void Update()
    {
        scoreText.GetComponent<Text>().text = "SCORE:" + scoree;
    }
}
;