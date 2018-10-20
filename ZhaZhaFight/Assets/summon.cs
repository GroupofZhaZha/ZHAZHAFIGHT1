using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summon : MonoBehaviour {


    public GameObject monster;
	// Use this for initialization
	void Start () {
        Instantiate(monster, transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
