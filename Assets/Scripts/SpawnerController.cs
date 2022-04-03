using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour {
    public GameObject[] cubes;
    // Start is called before the first frame update
    void Start() {
        InvokeRepeating("SpawnCube", 2.0f, 0.5f);
    }
    
    void SpawnCube() {
        int cubeIdx;
        float xPos;
        string cubeType;
        
        if (Random.Range(0, 2) == 0) {
            cubeType = "blue";
        } else {
            cubeType = "red";
        }
        
        if (cubeType == "blue") {
            xPos = -1.2f;
            cubeIdx = 0;
        } else {
            xPos = 1.2f;
            cubeIdx = 1;
        }
        
        var cube = GameObject.Instantiate(cubes[cubeIdx]);
        cube.transform.position = new Vector3(xPos, 0, 16);
    }

    // Update is called once per frame
    void Update() {
    }
}
