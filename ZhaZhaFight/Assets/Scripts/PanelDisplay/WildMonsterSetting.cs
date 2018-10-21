using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WildMonsterSetting : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        
       

	}

    // Update is called once per frame
    void Update()
    {



        float timeLeft = PlayerPrefs.GetFloat("time");
        timeLeft -= Time.deltaTime;
        //string text = "Time: " + timeLeft.ToString("f0") + "s";
        //timerDisplay.text = text;
        PlayerPrefs.SetFloat("time", timeLeft);
        if (timeLeft <= 0f)
        {
            SceneManager.LoadScene("WildMonsters");

        }
    }
}
