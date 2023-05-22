using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour
{
    public float punt;
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("muro"))
        {
            punt++;
            Debug.Log(punt);
        }
    }
}
