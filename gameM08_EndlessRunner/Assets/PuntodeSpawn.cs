using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntodeSpawn : MonoBehaviour
{
    public GameObject muro;
    void Start()
    {
        Instantiate(muro, transform.position, Quaternion.identity);                                              
    }
}
