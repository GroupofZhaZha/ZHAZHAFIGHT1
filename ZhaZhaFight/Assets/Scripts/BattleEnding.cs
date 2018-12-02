using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BattleEnding : MonoBehaviour {

    private float countDown = 2f;
    private bool done = false;
    private bool end = false;
    public Text result;
    public GameObject EndPanel;

	// Use this for initialization
	void Start () {
        EndPanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        if (end){
            done = false;
            EndPanel.SetActive(true);
            return;
        }
        if (done)
        {
            if (countDown <= 0)
            {
                countDown += 2;
                SceneManager.LoadScene("Game");
                PlayerPrefs.SetFloat("time", 20);
                botMonsterController.resetBotMonster();
                int gold = PlayerPrefs.GetInt("gold");
                PlayerPrefs.SetInt("gold", gold + 1000);
            }
            countDown -= Time.deltaTime;
            return;
        } 

        if (GameObject.FindGameObjectsWithTag("Ally").Length <= 0)
        {
            done = true;
            int playerhp = PlayerPrefs.GetInt("hp");
            PlayerPrefs.SetInt("hp", playerhp - GameObject.FindGameObjectsWithTag("Enemy").Length);

        }
        if (GameObject.FindGameObjectsWithTag("Enemy").Length <= 0)
        {
            done = true;
            int aihp = PlayerPrefs.GetInt("aihp");
            //PlayerPrefs.SetInt("aihp", aihp - GameObject.FindGameObjectsWithTag("Ally").Length);
        }
        if(PlayerPrefs.GetInt("aihp")<=0){
            end = true;
            result.text = "Victory";
        }
    
        if(PlayerPrefs.GetInt("hp")<=0){
            end = true;
            result.text = "Defeated";
        }


    }
}
