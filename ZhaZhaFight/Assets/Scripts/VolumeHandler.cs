using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeHandler : MonoBehaviour {

    public Slider changeVolume;
    public AudioSource backgroudnMusic;
	// Update is called once per frame
	void Update () {
        backgroudnMusic.volume = changeVolume.value;
	}
}
