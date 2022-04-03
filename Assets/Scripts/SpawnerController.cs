using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour {
    public GameObject[] cubes;
    // Start is called before the first frame update
    void Start() {
        GameManager.TickEvent += SpawnCube;
    }
    
    void SpawnCube() {
        // Should be set to multiple of BPS
        const float zPos = 20f;
        const float cubeHitZone = 0f;
        const float travelTimeInBeats = 6f;
        // TODO Pull 140f (bpm) from GameManager
        const float beatsPerSecond = 60f / 140f;
        // Set cube speed to multiple of BPM * distance needed from spawn to hit zone
        const float cubeSpeed = (zPos - cubeHitZone) / (beatsPerSecond * travelTimeInBeats);
        
        var cubeType = Random.Range(0, 2) == 0 ? "blue" : "red";

        // Randomize spawn of left or right
        var xPos = Random.Range(0, 2) == 0 ? -1.2f : 1.2f;
        var cubeIdx = cubeType == "blue" ? 0 : 1;
        
        var cube = GameObject.Instantiate(cubes[cubeIdx]);
        cube.transform.position = new Vector3(xPos, 1f, zPos);
        cube.GetComponent<BeatSaberCubeController>().speed = cubeSpeed;
        cube.GetComponent<BeatSaberCubeController>().color = cubeType;
    }
}
