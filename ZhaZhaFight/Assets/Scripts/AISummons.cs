using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISummons : MonoBehaviour {

    public static Transform[] locations;
    public GameObject go;

    // Use this for initialization
    void Start () {
        locations = new Transform[transform.childCount];
        for (int i = 0; i < locations.Length; i++)
        {
            if (i != 1) {
            locations[i] = transform.GetChild(1);
            GameObject temp = go.transform.GetChild(0).gameObject;
            GameObject monster = (GameObject) Instantiate(temp, locations[i].position, locations[i].rotation);
            monster.transform.localScale = new Vector3(5f, 5f, 5f);
            monster.tag = "Enemy";
            monster.AddComponent<AIMonster>();
            }
        }
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
