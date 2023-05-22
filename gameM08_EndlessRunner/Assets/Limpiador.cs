using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limpiador : MonoBehaviour
{
    public float tvida;
    private void Start()
    {
        Destroy(gameObject, tvida);
    }


}
