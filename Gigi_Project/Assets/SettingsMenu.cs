﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
   

    public void SetMainVolume (float volume)
    {
        audioMixer.SetFloat("Music", volume);
    }

    public void SetSFXVolume(float volume)
    {
        audioMixer.SetFloat("Effects", volume);
    }
}
