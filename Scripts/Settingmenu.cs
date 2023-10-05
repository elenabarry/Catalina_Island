using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Settingmenu : MonoBehaviour
{
    //SETTINGS MENU in Unity, by Brakeys (https://www.youtube.com/watch?v=YOaYQrN1oYQ&t=188s)
    //full script used and adapted to my game
    public AudioMixer audioMixer;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
