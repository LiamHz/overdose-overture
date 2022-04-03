using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyable : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Destroyer"))
        {
            Instantiate(PrefabFactory.DeathParticles, this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
