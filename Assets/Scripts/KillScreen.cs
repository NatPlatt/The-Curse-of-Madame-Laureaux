using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScreen : MonoBehaviour
{
    public bool GameIsPaused = false;

    public GameObject killScreenUI;

    private void Start()
    {
        GameIsPaused = false;
        Resume();
    }

    void Update()
    {
        if (killScreenUI.activeInHierarchy)
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        
    }
    
    public void Resume()
    {
        killScreenUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        killScreenUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
