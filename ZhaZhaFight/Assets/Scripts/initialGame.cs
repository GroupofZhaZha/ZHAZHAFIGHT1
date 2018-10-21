using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initialGame : MonoBehaviour {
	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("hp", 100);
        PlayerPrefs.SetInt("totalMoney", 10000);
        PlayerPrefs.SetFloat("time", 60f);
        PlayerPrefs.SetInt("currentId", 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
