using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class StatSO : ScriptableObject
{
    public StatId Id;
    public float Amount;
}

public enum StatId {
    ATS,
    HP,
    MOV,
    MANA
}