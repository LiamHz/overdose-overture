using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;


public class GameManager : MonoBehaviour {
    public float bpm = 20;
    public static event Action TickEvent;
    public AudioSource songSource;
    public AudioSource hitSource;
    public AudioSource missSource;
    public static event Action IncreaseScoreEvent;
    public static event Action DecreaseScoreEvent;
    private static int score = 0;
    public static int Score => score;

    void TriggerTickEvent() {
        TickEvent?.Invoke();
        
        // Trigger eighth notes with some probability
        if (Random.value < 0.16) {
            Invoke("TriggerTickEvent", 60f / bpm / 2);
        }
    } 

    // Start is called before the first frame update
    void Start() {
        songSource.Play();
        InvokeRepeating(
            "TriggerTickEvent",
            0f,
            60f / bpm
        );
        IncreaseScoreEvent += PlayHitSound;
        DecreaseScoreEvent += PlayMissSound;
    }
    
    void PlayHitSound() {
        hitSource.Play();
    }
    void PlayMissSound() {
        missSource.Play();
    }
    public static void IncreaseScore()
    {
        score++;
        IncreaseScoreEvent?.Invoke();
    }
    
    public static void DecreaseScore()
    {
        score--;
        DecreaseScoreEvent?.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
