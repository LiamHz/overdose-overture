using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class GameManager : MonoBehaviour {
    public float bpm = 20;
    public static event Action TickEvent;

    void TriggerTickEvent() {
        TickEvent?.Invoke();
    } 

    // Start is called before the first frame update
    void Start() {
        InvokeRepeating(
            "TriggerTickEvent",
            60f / bpm,
            60f / bpm
        );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
