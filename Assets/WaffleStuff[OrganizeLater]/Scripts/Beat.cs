using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "Beat", menuName = "ScriptableObjects/Beat", order = 1)]
public class Beat : ScriptableObject
{
    public List<Sprite> beatSprite;
    public float TimeToHitOnTime;
}
