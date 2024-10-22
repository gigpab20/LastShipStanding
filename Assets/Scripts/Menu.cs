using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void OnPlayButton(){
        SceneManager.LoadScene(1);
    }

    public void OnQuitButton(){
        Application.Quit();
    }

    public void OnOptionButton(){
        SceneManager.LoadScene("OptionScene");
    }

    public void OnSaveAndExitButton(){
        SceneManager.LoadScene(0);
    }

    public void OnMenuButton(){
        SceneManager.LoadScene("MainMenu");
    }
}
