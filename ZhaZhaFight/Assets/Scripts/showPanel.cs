using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class showPanel : MonoBehaviour {

    public Button bt;
    public GameObject gb;

    // Use this for initialization
    void Start () {
        bt.onClick.AddListener(buttonListener);
    }

    // Update is called once per frame
    void buttonListener()
    {
        gb.SetActive(false);
    }

}
