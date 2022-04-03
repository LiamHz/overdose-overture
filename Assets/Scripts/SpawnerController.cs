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
        int cubeIdx;
        float xPos;
        string cubeType;
        
        cubeType = Random.Range(0, 2) == 0 ? "blue" : "red";

        // Randomize spawn of left or right
        xPos = Random.Range(0, 2) == 0 ? -1.2f : 1.2f;
        cubeIdx = cubeType == "blue" ? 0 : 1;
        
        var cube = GameObject.Instantiate(cubes[cubeIdx]);
        cube.transform.position = new Vector3(xPos, 1f, 16);
    }

    // Update is called once per frame
    void Update() {
    }
}
