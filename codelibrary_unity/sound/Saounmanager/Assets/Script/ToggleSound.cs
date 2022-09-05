using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSound : MonoBehaviour
{
    [SerializeField] private bool _toggleMusic, _toggleEfect;

    public void Toggle(){
        if (_toggleMusic) SoundManager.Instance.ToggleMusic();
        if (_toggleEfect) SoundManager.Instance.ToggleEffects();
    }
}
