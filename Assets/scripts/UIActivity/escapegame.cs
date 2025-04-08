using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class escapegame : MonoBehaviour
{
    public GameObject ob;
    int scen;

    private bool isPaused = false;

    private void Start()
    {
        scen = SceneManager.GetActiveScene().buildIndex;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused) ResumeGame();
            else PauseGame();
        }
        if (scen == 0)
        {
            ResumeGame();
        }
    }
    public void PauseGame()
    {
        SpawnMenu(true);
        Time.timeScale = 0f;
        isPaused = true;
        // Pause all audio
        AudioListener.pause = true;
    }
    public void ResumeGame()
    {
        SpawnMenu(false);
        Time.timeScale = 1f;
        isPaused = false;
        // Resume all audio
        AudioListener.pause = false;
    }
    void SpawnMenu(bool bob)
    {
        if(ob != null)
            ob.SetActive(bob);
    }

    public void OnExitGame()
    {
        Application.Quit();
    }
}
