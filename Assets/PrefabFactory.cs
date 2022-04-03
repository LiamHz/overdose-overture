using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://forum.unity.com/threads/singleton-used-to-host-prefabs.759353/

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/PrefabFactory", order = 1)]

public class PrefabFactory : ScriptableObject
{
    private static PrefabFactory instance;
    private static PrefabFactory Instance {
        get {
            if (instance == null)
                instance = Resources.Load<PrefabFactory>("PrefabFactory");
 
            return instance;
        }
    }
    
    [SerializeField] private GameObject deathParticles;
    public static GameObject DeathParticles => Instance.deathParticles;

}
