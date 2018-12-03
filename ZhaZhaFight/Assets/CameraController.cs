using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    
	// Update is called once per frame
	void Update () {
        if (Input.touchCount == 0)
        {
            return;
        }
        Touch touch = Input.GetTouch(0);
        Vector3 prevPosi = transform.position;
        if (touch.position.x < 400)
        {
            this.transform.Translate(Vector3.right * Time.deltaTime * 30f, Space.World);
            if (this.transform.position.x > 320)
            {
                this.transform.position = prevPosi;
            }
        }
        if (touch.position.x > Screen.width - 400)
        {
            this.transform.Translate(Vector3.left * Time.deltaTime * 30f, Space.World);
            if (this.transform.position.x < -320)
            {
                this.transform.position = prevPosi;
            }
        }
        if (touch.position.y < 400)
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime * 30f, Space.World);
            if (this.transform.position.z > 450f)
            {
                this.transform.position = prevPosi;
            }
        }
        if (touch.position.y > Screen.height - 400)
        {
            this.transform.Translate(Vector3.down* Time.deltaTime * 30f, Space.World);
            if (this.transform.position.z < 200f)
            {
                this.transform.position = prevPosi;
            }
        }
	}
}
