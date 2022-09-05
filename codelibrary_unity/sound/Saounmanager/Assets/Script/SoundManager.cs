using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    [SerializeField] private AudioSource _musicSource, _effectSource;

    private void Awake() {
        if (Instance == null){
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySound(AudioClip audio){
        _effectSource.PlayOneShot(audio);
    }

    public void ChangeMasterVolume(float value){
        AudioListener.volume = value;
    }

    public void ToggleEffects(){
        _effectSource.mute = !_effectSource.mute;
    }

    public void ToggleMusic(){
        _musicSource.mute = !_musicSource.mute;
    }
}
