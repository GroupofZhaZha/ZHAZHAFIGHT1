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
            this.transform.Translate(Vector3.left * Time.deltaTime * 10f, Space.World);
            if (this.transform.position.x <= -125)
            {
                this.transform.position = prevPosi;
            }
        }
        if (touch.position.x > Screen.width - 400)
        {
            this.transform.Translate(Vector3.right * Time.deltaTime * 10f, Space.World);
            if (this.transform.position.x >= 133)
            {
                this.transform.position = prevPosi;
            }
        }
        if (touch.position.y < 400)
        {
            this.transform.Translate(Vector3.down * Time.deltaTime * 10f, Space.World);
            if (this.transform.position.y <=143)
            {
                this.transform.position = prevPosi;
            }
        }
        if (touch.position.y > Screen.height - 400)
        {
            this.transform.Translate(Vector3.up * Time.deltaTime * 10f, Space.World);
            if (this.transform.position.y >= 196)
            {
                this.transform.position = prevPosi;
            }
        }
	}
}
