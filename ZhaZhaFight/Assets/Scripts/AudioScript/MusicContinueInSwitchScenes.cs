using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicContinueInSwitchScenes : MonoBehaviour {

    // Use this for initialization 
    public bool DontDestroyOnLoad = true;
    public static MusicContinueInSwitchScenes instance = null;
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame

}
