using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moneyManager : MonoBehaviour {

    public Text moneyText;
    public static int totalMoney;
	// Use this for initialization
	void Start () {
        totalMoney = PlayerPrefs.GetInt("totalMoney");

        moneyText.text = "                             Gold : "+totalMoney.ToString();
        print(PlayerPrefs.GetInt("totalMoney"));
    }
	
	// Update is called once per frame
	void Update () {
        totalMoney = PlayerPrefs.GetInt("totalMoney");
        moneyText.text = "                             Gold : " + totalMoney.ToString();
    }
}
