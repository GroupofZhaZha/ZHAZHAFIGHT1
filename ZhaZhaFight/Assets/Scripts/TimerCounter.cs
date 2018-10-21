using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimerCounter : MonoBehaviour {
    
    public  Text timerDisplay;
    public float timeLeft;
    public bool isPause = false;
	// Use this for initialization
	void Start () {
        

        timeLeft = PlayerPrefs.GetFloat("time");
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
                SceneManager.LoadScene("WildMonsters");
                PlayerPrefs.SetFloat("time", 30f);
            }

        }
	}

}
