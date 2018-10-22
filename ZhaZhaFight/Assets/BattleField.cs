using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BattleField : MonoBehaviour {


    public static Transform[] locations;
    public GameObject monsterdb;



    public GameObject robotman;
    public GameObject pclock;

    public GameObject loc1;
    public GameObject loc2;
    public GameObject loc3;
	// Use this for initialization

	void Start () {
        List<Monster> list = wildMonsterController.ownList;

        for (int i = 0; i < locations.Length;i++){
            locations[i] = transform.GetChild(i);
            GameObject tempMonster = monsterdb.transform.GetChild(0).gameObject;
            GameObject monster;




        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
