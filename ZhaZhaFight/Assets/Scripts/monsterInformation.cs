using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class monsterInformation : MonoBehaviour {

    // Use this for initialization
	void Start () {
        RectTransform monsterInformation;

        monsterInformation = transform as RectTransform;

        monsterInformation.SetAsLastSibling();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
