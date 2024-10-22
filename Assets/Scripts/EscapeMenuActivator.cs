using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Escape : MonoBehaviour
{
    public Button escape;
    public Button continueButton;     
    public Button mainMenu;
    public bool EscapeMenuOpen;
    public TextMeshProUGUI pauseText;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!EscapeMenuOpen)
            {
                EscapeMenuOpen = true;
                mainMenu.gameObject.SetActive(true);
                escape.gameObject.SetActive(true);
                continueButton.gameObject.SetActive(true);
                pauseText.gameObject.SetActive(true);  
                Time.timeScale = 0;  
            }
            else
            {
                EscapeMenuOpen = false;
                mainMenu.gameObject.SetActive(false);
                escape.gameObject.SetActive(false);
                continueButton.gameObject.SetActive(false);
                pauseText.gameObject.SetActive(false);  
                Time.timeScale = 1;  
            }
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ContinueGame()
    {
        EscapeMenuOpen = false;
        mainMenu.gameObject.SetActive(false);
        escape.gameObject.SetActive(false);
        continueButton.gameObject.SetActive(false);
        pauseText.gameObject.SetActive(false);  // Hide the pause text when resuming the game
        Time.timeScale = 1; 
    }

    // Loads the Main Menu scene
    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
