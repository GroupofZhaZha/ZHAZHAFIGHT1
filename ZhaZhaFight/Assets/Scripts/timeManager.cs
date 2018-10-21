using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timeManager : MonoBehaviour {

    public Text timeText;
    public float time;
    // Use this for initialization
    void Start()
    {
        time = PlayerPrefs.GetFloat("time");
        timeText.text = "Time : " + time.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        time = PlayerPrefs.GetInt("time");
        timeText.text = "Time : " + time.ToString();
    }
}
