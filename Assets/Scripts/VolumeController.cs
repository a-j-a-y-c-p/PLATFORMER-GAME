using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    private void Start() {
        LoadValues();
    }

    // public AudioMixer mixer;
    [SerializeField] private Slider volumeSlider = null;

    // public void SetLevel(float sliderValue)
    // {
    //     mixer.SetFloat("MusicVol", Mathf.Log10 (sliderValue) * 20);
    // }

    public void VolumeSlider(float volume){
        
    }

    public void SaveVolumeButton()
    {
        float volumeValue = volumeSlider.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValue);
        LoadValues();
    }

    void LoadValues()
    {
        float volumeValue = PlayerPrefs.GetFloat("VolumeValue");
        volumeSlider.value = volumeValue;
        AudioListener.volume = volumeValue;
    }
}
