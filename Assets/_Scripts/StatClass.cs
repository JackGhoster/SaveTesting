using System;
using UnityEngine;

[Serializable]
public class StatClass
{
    public StatId Id;
    public float Amount;

    public StatClass(StatId id, float amount)
    {
        Id = id; 
        Amount = amount;
    }
}
