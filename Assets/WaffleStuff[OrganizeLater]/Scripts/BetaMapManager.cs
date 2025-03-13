using System;
using System.Collections.Generic;
using UnityEngine;

public class BetaMapManager : MonoBehaviour
{
    [SerializeField] private List<Beat> topRow;
    [SerializeField] private List<Beat> botRow;
    [Tooltip("Time to spawn, seconds before TimeToHit")]
    public float SpawnTimeOffset;
    public Vector3 SpawnPos;
    [Tooltip("When the beat should be clicked for a perfect score")]
    public Vector3 FinalPos;
    [Tooltip("Where the beat will despawn X units after finalPos")]
    public float DespawnOffset;

    private void Start() {
        
    }

    private void Awake() {
        
    }
}
