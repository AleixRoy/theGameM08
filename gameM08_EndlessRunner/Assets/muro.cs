using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muro : MonoBehaviour
{
    public int damage = 1;
    public float speed;
    public GameObject efecto;
    public Animator camAnim;
    public GameObject expsound;

    
    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
   void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            Instantiate(efecto, transform.position, Quaternion.identity);
            other.GetComponent<Player>().health -= damage;
            Debug.Log(other.GetComponent<Player>().health);
            Destroy(gameObject);
            //player gets hurt 
            Instantiate(expsound, transform.position, Quaternion.identity);
        }
    }
}
