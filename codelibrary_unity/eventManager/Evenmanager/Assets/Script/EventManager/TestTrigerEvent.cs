using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTrigerEvent : MonoBehaviour
{
    void Update() {
        if (Input.GetMouseButtonDown(0))
        {
            EventManager.TriggerEvent("Spawn");
            Debug.Log("click mouse");
        }
    }
}
