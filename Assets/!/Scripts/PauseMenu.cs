using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject crosshair;
    public bool isPaused;

    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            if(isPaused)
            {
                ResumeGame();
                
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        crosshair.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;
        Screen.lockCursor = false;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        crosshair.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;
        Screen.lockCursor = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
