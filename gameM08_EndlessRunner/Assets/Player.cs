using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Vector2 PosicionDestino;
    public float Yincrement;
    public float AlturaMaxima;
    public float AlturaMinima;
    public int health = 3;
    public float speed;
    public GameObject explos, UI, POP, gameover;
    public Text vida;

    private void Update()
    {
        vida.text = health.ToString();
        if (health <= 0)
        {
            gameover.SetActive(true);
            Destroy(gameObject);
        }
        transform.position = Vector2.MoveTowards(transform.position, PosicionDestino, speed * Time.deltaTime);

        //if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        //{
        //    Instantiate(POP, transform.position, Quaternion.identity);
        //    Instantiate(explos, transform.position, Quaternion.identity);
        //    targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);

        //}
        //else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        //{
        //    Instantiate(POP, transform.position, Quaternion.identity);
        //    Instantiate(explos, transform.position, Quaternion.identity);
        //    targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);

        //}

        var collider_up = UI.transform.GetChild(0).GetComponent<Collider2D>();
        var collider_dw = UI.transform.GetChild(1).GetComponent<Collider2D>();

        var toque  = Input.touchCount > 0;
        
        if(toque)
        {
            var mover = Input.GetTouch(0);
            var punto = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

            var arriba = collider_up.OverlapPoint(punto);
            var abajo  = collider_dw.OverlapPoint(punto);

            if (arriba && PosicionDestino.y < AlturaMaxima)
            {
                switch (mover.phase)
                {
                    case TouchPhase.Began:
                        Instantiate(POP, transform.position, Quaternion.identity);
                        Instantiate(explos, transform.position, Quaternion.identity);
                        PosicionDestino = new Vector2(transform.position.x, transform.position.y + Yincrement);
                        break;

                    default: break;
                }
            }

            if (abajo && PosicionDestino.y > AlturaMinima)
            {
                switch (mover.phase)
                {
                    case TouchPhase.Began:
                        Instantiate(POP, transform.position, Quaternion.identity);
                        Instantiate(explos, transform.position, Quaternion.identity);
                        PosicionDestino = new Vector2(transform.position.x, transform.position.y - Yincrement);
                        break;

                    default: break;
                }
            }
        }
    }
}