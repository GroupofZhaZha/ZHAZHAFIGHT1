using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MonsterListClick : MonoBehaviour {

    public Button bt;
    public Text price;
    public int monsterPrice;
    // Use this for initialization
    void Start()
    {
        string s = price.text;
        string subs = "";
        for(int i = 0; i < s.Length; ++i)
        {
            if (char.IsDigit(s[i]))
            {
                subs += s[i];
            }
        }
        int.TryParse(subs, out monsterPrice);
        print("hello"+monsterPrice);

        bt.onClick.AddListener(buttonListener);
    }
    void Update()
    {
        print(PlayerPrefs.GetInt("totalMoney"));
    }
    void onClick()
    {
    }
    void buttonListener()
    {
        int totalMoney = PlayerPrefs.GetInt("totalMoney") - monsterPrice;
        PlayerPrefs.SetInt("totalMoney", totalMoney);
    }
}
