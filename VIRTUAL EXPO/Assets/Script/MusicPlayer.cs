﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour
{
    

   public Slider volumeSlider;
   public GameObject ObjectMusic;

   private float musicVolume = 1f;
   private AudioSource AudioSource;


   private void Start()
   {
       ObjectMusic = GameObject.FindWithTag("GameMusic");
       AudioSource = ObjectMusic.GetComponent<AudioSource>();

       AudioSource.Play();
       musicVolume = PlayerPrefs.GetFloat("volume");
       AudioSource.volume = musicVolume;
       volumeSlider.value = musicVolume;
   }

   private void Update()
   {
       AudioSource.volume = musicVolume;
       PlayerPrefs.SetFloat("volume", musicVolume);
   }

   public void updateVolume( float volume)
   {
       musicVolume = volume;
   }
}
