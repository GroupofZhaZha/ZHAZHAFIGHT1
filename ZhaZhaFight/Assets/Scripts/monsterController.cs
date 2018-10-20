using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class monsterController : MonoBehaviour {

    // Use this for initialization
    public Text monsterName;
    public Text monsterLevel;
    public Text monsterDamage;
    public Text monsterArmor;
    public Text monsterPrice;
    public Text monsterHealth;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButton(0)){
            monsterName.text = "Name : " + (500).ToString();
            monsterLevel.text = "Lv : " + (1).ToString();
            monsterDamage.text = "Damage : " + (200).ToString();
            monsterArmor.text = "Armor : " + (50).ToString();
            monsterPrice.text = "Price : " + (500).ToString();
            monsterHealth.text = "Health: " + (2000).ToString();
        }
	}

}
