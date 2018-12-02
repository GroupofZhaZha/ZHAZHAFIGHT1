using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AiHpUpdate : MonoBehaviour {
    public Text aiHp;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int hp = PlayerPrefs.GetInt("aihp");
        aiHp.text = "AiHP: " + hp.ToString();
	}
}
