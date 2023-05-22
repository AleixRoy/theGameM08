using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    public Transform[] movespots;
    private int Rs;
    private float tdesp;
    public float swt;

    void Start()
    {
        tdesp = swt;
        Rs = Random.Range(0, movespots.Length);

    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, movespots[Rs].position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, movespots[Rs].position) < 0.2f)
        {
            if (tdesp <= 0)
            {
                Rs = Random.Range(0, movespots.Length);
                tdesp = swt;
            }
            else
            {
                tdesp -= Time.deltaTime;
            }
        }

    }

}









