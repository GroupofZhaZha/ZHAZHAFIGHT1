using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.IO;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour {

    public GameObject PausePanelUI;
    public static List<Monster> totalMonster = new List<Monster>();

    public void PlayGameButtonHandler()
    {
        PlayerPrefs.SetInt("hp", 30);
        PlayerPrefs.SetFloat("time", 20f);
        PlayerPrefs.SetInt("gold", 2000);
        PlayerPrefs.SetInt("currentId", 0);
        PlayerPrefs.SetInt("aihp", 30);
        wildMonsterController.resetOwnMonsterList();

        SceneManager.LoadScene("Game");

        TextAsset monstertext = Resources.Load("totalMonster", typeof(TextAsset)) as TextAsset;

        string[] data = monstertext.text.Split('\n');
        for (int i = 1; i < data.Length; ++i)
        {
            string[] row = data[i].Split(',');

            Monster m = new Monster(0, null, 0, 0, 0, 0, 0, 0, 0);

            int.TryParse(row[0], out m.id);
            m.monsterName = row[1];
            int.TryParse(row[2], out m.level);
            int.TryParse(row[3], out m.health);
            int.TryParse(row[4], out m.damage);
            int.TryParse(row[5], out m.armor);
            int.TryParse(row[6], out m.price);
            int.TryParse(row[7], out m.sell);
            int.TryParse(row[8], out m.goldUpgrade);
            totalMonster.Add(m);
        }

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
