using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zhaszxha : MonoBehaviour {

    public Transform camera1;
	// Update is called once per frame
	void Update () {
        if(Input.GetKey("w")){
            camera1.Translate(Vector3.forward * 100*Time.deltaTime, Space.World);
        }         
	}

}
