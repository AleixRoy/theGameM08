using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keys : MonoBehaviour {

    public AudioSource sonidorecogida;
    void OnTriggerEnter(Collider other)
    {
        sonidorecogida.Play();
        //SistemaR.scoree += 50;
        Destroy(gameObject);
    }
}
