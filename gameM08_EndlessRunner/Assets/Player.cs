using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    
    
    public float Yincrement;
    public float maxHeight;
    public float minHeight;
    public int health = 3;
    public float speed;
    public GameObject explos;
    public Text vida;
    public GameObject POP;
    public GameObject gameover;

    private void Update()
    {
        vida.text = health.ToString();
        if (health <= 0)
        {
            gameover.SetActive(true);
            Destroy(gameObject);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            Instantiate(POP, transform.position, Quaternion.identity);
            Instantiate(explos, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
          
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            Instantiate(POP, transform.position, Quaternion.identity); 
            Instantiate(explos, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            
        }
    }
}

