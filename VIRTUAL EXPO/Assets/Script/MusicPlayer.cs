using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour
{
   public Slider volumeSlider;
   public GameObject ObjectMusic;

    //value from the slider, and it converts to volume level
   private float musicVolume = 0f;
   private AudioSource AudioSource;


   private void Start()
   {
       ObjectMusic = GameObject.FindWithTag("GameMusic");
       AudioSource = ObjectMusic.GetComponent<AudioSource>();

       musicVolume = PlayerPrefs.GetFloat("volume");
       AudioSource.volume = musicVolume;
       volumeSlider.value = musicVolume;
   }

   private void Update()
   {
       AudioSource.volume = musicVolume;
       PlayerPrefs.SetFloat("volume", musicVolume);
   }

   public void VolumeUpdater( float volume)
   {
       musicVolume = volume;
   }
}
