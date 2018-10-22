using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.IO;

public class ButtonHandler : MonoBehaviour {

    public GameObject PausePanelUI;

	public void PlayGameButtonHandler()
    {
        PlayerPrefs.SetInt("hp", 30);
        PlayerPrefs.SetFloat("time", 10f);
        PlayerPrefs.SetInt("gold", 1000);
        PlayerPrefs.SetInt("currentId", 0);

        wildMonsterController.resetOwnMonsterList();

        SceneManager.LoadScene("Game");


        //string[] s = new string[0];
        //File.WriteAllLines("Assets/Resources/ownList.txt", s);

        //AssetDatabase.ImportAsset("Assets/Resources/ownList.txt");


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
