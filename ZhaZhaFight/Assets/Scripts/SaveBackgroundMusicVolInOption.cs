using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveBackgroundMusicVolInOption : MonoBehaviour
{

    public Slider Volume;
    public AudioSource Music;
    // Use this for initialization


    void Start()
    {
        Volume.value = PlayerPrefs.GetFloat("BackgroundMusicVol");
        PlayerPrefs.SetFloat("BackgroundMusicVol", Volume.value);
    }
    void Update()
    {
        if (Volume.value != PlayerPrefs.GetFloat("BackgroundMusicVol"))
        {
            PlayerPrefs.SetFloat("BackgroundMusicVol", Volume.value);
        }
        
    }
}
