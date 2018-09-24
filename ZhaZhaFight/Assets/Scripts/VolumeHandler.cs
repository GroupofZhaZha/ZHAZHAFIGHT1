using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeHandler : MonoBehaviour {

    public Slider changeVolume;
    public AudioSource backgroudnMusic;
    // Update is called once per frame
    private void Start()
    {
        changeVolume.value = PlayerPrefs.GetFloat("Volume");
    }
    void Update () {
        backgroudnMusic.volume = changeVolume.value;
        PlayerPrefs.SetFloat("Volume", backgroudnMusic.volume);
	}
    public void VlumePref(){
        PlayerPrefs.SetFloat("Volume", backgroudnMusic.volume);
    }
}
