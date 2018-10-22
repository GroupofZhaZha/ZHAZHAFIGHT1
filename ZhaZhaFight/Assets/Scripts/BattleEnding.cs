using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleEnding : MonoBehaviour {

    private float countDown = 2f;
    private bool done = false;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (done)
        {
            if (countDown <= 0)
            {
                SceneManager.LoadScene("Game");
            }
            countDown -= Time.deltaTime;
            return;
        } 
        if (GameObject.FindGameObjectsWithTag("Ally").Length <= 0)
        {
            done = true;
        }
        if (GameObject.FindGameObjectsWithTag("Enemy").Length <= 0)
        {
            done = true;
        }



    }
}
