using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool pausedgame = false;
    public GameObject pmu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (pausedgame)
            {
                Resume();
            } 
            else {
                Pause();
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
