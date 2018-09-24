using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackgroundMusicVol : MonoBehaviour {

    public AudioSource s;
    // Use this for initialization
    void Start()
    {
        s = GetComponent<AudioSource>();
        s.volume = PlayerPrefs.GetFloat("BackgroundMusicVol", s.volume);
    }
    void Update()
    {
        if (s.volume != PlayerPrefs.GetFloat("BackgroundMusicVol"))
        {
            s.volume = PlayerPrefs.GetFloat("BackgroundMusicVol", s.volume);
        }    
    }
}
