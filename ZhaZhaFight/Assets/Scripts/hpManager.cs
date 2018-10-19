using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hpManager : MonoBehaviour {

    // Use this for initialization
    public Text hpText;
    public static int totalHp;
    void Start () {
        totalHp = PlayerPrefs.GetInt("hp");
        hpText.text = " HP : " + totalHp.ToString();
        
	}
	
	// Update is called once per frame
	void Update () {
        totalHp = PlayerPrefs.GetInt("hp");
        hpText.text = " HP : " + totalHp.ToString();

    }
}
