using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puase : MonoBehaviour
{

    public static bool ispaused = false;
    public GameObject PauseMenuUI;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (ispaused)
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
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        ispaused = false;
    }

    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        ispaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        ispaused = false;

        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }

    public void restart()
    {
        Time.timeScale = 1f;
        ispaused = false;

        SceneManager.LoadScene(0);
    }

}
