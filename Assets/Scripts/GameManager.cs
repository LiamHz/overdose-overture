using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;


public class GameManager : MonoBehaviour {
    public float bpm = 20;
    public static event Action TickEvent;
    public AudioSource audioSource;

    void TriggerTickEvent() {
        TickEvent?.Invoke();
        
        // Trigger eighth notes with some probability
        if (Random.value < 0.16) {
            Invoke("TriggerTickEvent", 60f / bpm / 2);
        }
    } 

    // Start is called before the first frame update
    void Start() {
        audioSource.Play();
        InvokeRepeating(
            "TriggerTickEvent",
            0f,
            60f / bpm
        );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
