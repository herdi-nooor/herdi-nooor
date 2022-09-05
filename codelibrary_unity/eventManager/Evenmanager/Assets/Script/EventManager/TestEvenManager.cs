using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TestEvenManager : MonoBehaviour
{
    private UnityAction onClick;

    private void Awake() {
        onClick = new UnityAction (OnClick);
    }

    private void OnEnable() {
        EventManager.StartListening ("Spawn", onClick);
    }

    private void OnDisable() {
        EventManager.StopListening ("Spawn", onClick);
    }

    void OnClick()
    {
        Debug.Log ("OnClik");
    }
}
