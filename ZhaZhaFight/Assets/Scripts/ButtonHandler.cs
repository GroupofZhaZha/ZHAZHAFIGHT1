using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour {

    public GameObject PausePanelUI;

	public void PlayGameButtonHandler()
    {
        PlayerPrefs.SetInt("hp", 30);
        PlayerPrefs.SetFloat("time", 30f);
        PlayerPrefs.SetInt("gold", 1000);
        SceneManager.LoadScene("Game");
    }
    public void backToGameScene(){
        SceneManager.LoadScene("Game");
    }
    public void pauseButtonHandler(){
        PausePanelUI.SetActive(true);

    }
    public void ResumeButtonHandler(){
        PausePanelUI.SetActive(false);
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

    public void MyMonsterButtonHandler()
    {
        SceneManager.LoadScene("MyMonsters");
    }

    public void WildMonsterButtonHandler()
    {
        SceneManager.LoadScene("WildMonsters");
    }

    public void BOTButtonHandler()
    {
        SceneManager.LoadScene("BOT");
    }

}
