using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class StatContainer : ScriptableObject
{
    public List<StatSO> Stats = new List<StatSO>();
}
