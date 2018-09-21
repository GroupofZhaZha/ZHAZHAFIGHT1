using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour {
    
	public void PlayGameButtonHandler()
    {
        SceneManager.LoadScene("Game");
    }

    public void BackToMainMenuPanelButtonHandler()
    {
        SceneManager.LoadScene("main");
    }

    public void OptionButtonHandler()
    {
        SceneManager.LoadScene("Option");
    }

    public void CreditButtonHandler()
    {
        SceneManager.LoadScene("Credit");
    }

    public void QuitButtonHandler()
    {
        Application.Quit();
    }



}
