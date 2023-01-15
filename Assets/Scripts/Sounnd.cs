using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;



public class Sounnd : MonoBehaviour
{
    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider slider;

    public void SoundControl()
    {
        float sound = slider.value;

        if (sound == -40f)
            mixer.SetFloat("BGM", -80);
        else
            mixer.SetFloat("BGM", sound);
    }
 

    public void AudioToggle()
    {
        AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;
    }


}
