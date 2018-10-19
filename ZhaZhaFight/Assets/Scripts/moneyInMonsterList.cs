using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class moneyInMonsterList : MonoBehaviour {

    public Text moneyText;
    public int totalMoney;
	// Use this for initialization
	void Start () {
        totalMoney = PlayerPrefs.GetInt("totalMoney");
        moneyText.text = "Gold : " + totalMoney.ToString();

	}
	
	// Update is called once per frame
	void Update () {
        totalMoney = PlayerPrefs.GetInt("totalMoney");
        moneyText.text = "Gold : " + totalMoney.ToString();
    }
}
