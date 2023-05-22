using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucleBg : MonoBehaviour
{
    public float speed;
    public float finalX;
    public float comX;
    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if(transform.position.x <= finalX)
        {
            Vector2 pos = new Vector2(comX, transform.position.y);
            transform.position = pos;
        }
    }
}
