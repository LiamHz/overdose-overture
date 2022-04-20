using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    [HideInInspector] public string color;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            if ((other.gameObject.GetComponent<ObjectColor>().color == color))
            {
                Instantiate(PrefabFactory.DeathParticles, this.transform.position, Quaternion.identity);
                GameManager.IncreaseScore();
                Destroy(this.gameObject);
            }
            else
            {
                GameManager.DecreaseScore();
            }
        }
    }
}
