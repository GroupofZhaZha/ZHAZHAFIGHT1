using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotMonsters : MonoBehaviour {

    // Use this for initialization
    public static List<Monster> botMonster = new List<Monster>();
	void Start () {
        if (botMonster.Count == 0)
        {
            Random r = new Random();

            int numberOfMonster = Random.Range(1, 6);

            for (int i = 0; i < numberOfMonster; ++i)
            {

                botMonster.Add(ButtonHandler.totalMonster[Random.Range(0, 90)]);
            }
            botMonsterController.botList = botMonster;

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
