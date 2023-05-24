using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool pausedgame = false;
    public GameObject pmu, IconoPause;

    void Update()
    {
        var collider_pause = IconoPause.transform.GetChild(2).GetComponent<BoxCollider2D>();
        var toque = Input.touchCount > 0;

        if (toque)
        {
            var detectar = Input.GetTouch(0);
            var punto  = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            var pausar = collider_pause.OverlapPoint(punto);

            if(pausar)
            {
                switch (detectar.phase)
                {
                    case TouchPhase.Began:
                        Pause();
                        break;

                    default: break;
                }
            }
        }
    }

   public void Resume() {
        pmu.SetActive(false);
        Time.timeScale = 1f;
        pausedgame = false;
    }
    void Pause() {
        pmu.SetActive(true);
        Time.timeScale = 0f;
        pausedgame = true;
    }
    public void Loadmenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main menu");
    }
    public void salir()
    {

    }

}
