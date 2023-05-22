using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] muroPatron;
    private float tiempodeaparicion;
    public float tiempo;
    public float time2;
    public float minTime = 0.65f;

    private void Update(){
        if (tiempodeaparicion <= 0)
        {
            int rand = Random.Range(0, muroPatron.Length);
            Instantiate(muroPatron[rand], transform.position, Quaternion.identity);
            tiempodeaparicion = tiempo;
            if (tiempo > minTime)
            {
                tiempo -= time2;
            }
        }
        else
        {
            tiempodeaparicion -= Time.deltaTime;

        }
    }
}
