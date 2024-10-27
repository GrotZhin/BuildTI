using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System;

namespace MetalRay
{
    public class volumeSettings : MonoBehaviour
    {
        [SerializeField] private AudioMixer mixer;
        [SerializeField] private Slider musicSlider;

        private void Start()
        {
            
           if (PlayerPrefs.HasKey("musicVolume"))
           {
             LoadVolume();
           }
           else
           {
            SetMusicVolume();
           }
        }

        public void SetMusicVolume(){
            float volume = musicSlider.value;
            mixer.SetFloat("music", Mathf.Log10(volume) * 20);
            PlayerPrefs.SetFloat("musicVolume", volume);
        }

        private void LoadVolume(){
           
            musicSlider.value = PlayerPrefs.GetFloat("musicVolume");

            SetMusicVolume();
        }
    }
}