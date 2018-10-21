using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MonsterListClick : MonoBehaviour {

    public Button bt;
    public Text price;
    public Text AlertText;
    public int monsterPrice;
    public GameObject gb;
    // Use this for initialization
    void Start()
    {
        bt.onClick.AddListener(buttonListener);
        gb.SetActive(false);
    }
    void Update()
    {
    }
    void buttonListener()
    {
        string s = price.text;
        string subs = "";
        for (int i = 0; i < s.Length; ++i)
        {
            if (char.IsDigit(s[i]))
            {
                subs += s[i];
            }
            print(s[i]);

        }
        int.TryParse(subs, out monsterPrice);
        print("hello" + monsterPrice);
        int totalMoney = PlayerPrefs.GetInt("totalMoney") - monsterPrice;
        if (totalMoney < 0)
        {
            gb.SetActive(true);
            AlertText.text = "No enough Money!!!!!";
        }
        else
        {
            PlayerPrefs.SetInt("totalMoney", totalMoney);
        }
    }
}
