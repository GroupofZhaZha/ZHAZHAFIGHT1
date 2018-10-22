using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerCounter : MonoBehaviour {
    
    public  Text timerDisplay;
    public Text gold;
    public Text hp;

    public float timeLeft; 

    public bool isPause = false;
	// Use this for initialization
	void Start () {

        gold.text = "Gold:"+PlayerPrefs.GetInt("gold").ToString();
        hp.text = "HP:" + PlayerPrefs.GetInt("hp").ToString();

        timeLeft = PlayerPrefs.GetFloat("time");
        timerDisplay.text = "Time: " + timeLeft.ToString("f0") + "s";
	}
  
    public void setPause(){
        isPause = true;
    }
    public void setUnPause(){
        isPause = false;
    }
    // Update is called once per frame
    void Update () {
        if (!isPause)
        {
            timeLeft = PlayerPrefs.GetFloat("time");
            //print("open time: " + PlayerPrefs.GetFloat("time"));
            timeLeft -= Time.deltaTime;
            string text = "Time: " + timeLeft.ToString("f0") + "s";
            timerDisplay.text = text;
            PlayerPrefs.SetFloat("time", timeLeft);
            if (timeLeft <= 0f)
            {
                Debug.Log("YEa its bug");
                SceneManager.LoadScene("Battlefield");
                PlayerPrefs.SetFloat("time", 0f);
            }

        }

        	}

}

