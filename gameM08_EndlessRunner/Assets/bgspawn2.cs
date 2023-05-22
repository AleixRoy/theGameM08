using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgspawn2 : MonoBehaviour
{
    public float speed;
    public float finalX;
    public float comX;
    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x <= comX)
        {
            Vector2 pos = new Vector2(finalX, transform.position.y);
            transform.position = pos;
        }
    }
}
