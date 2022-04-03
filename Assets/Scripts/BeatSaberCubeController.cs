using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatSaberCubeController : MonoBehaviour
{
    [HideInInspector] public float speed = 10;
    [HideInInspector] public string color;

    void Update() {
        transform.position += Time.deltaTime * transform.forward * speed;
        if (transform.position.z < -2.0f) {
            Destroy(this.gameObject);
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
            if (other.CompareTag("LightSaber"))
            {
                Debug.Log("lightsaber color: " + other.gameObject.GetComponent<ObjectColor>().color);

                if ((other.gameObject.GetComponent<ObjectColor>().color == color))
                {
                    Debug.Log("block color: " + color);
                    Instantiate(PrefabFactory.DeathParticles, this.transform.position, Quaternion.identity);
                    GameManager.IncreaseScore();
                    Destroy(this.gameObject);
                }
            }
    }
}
