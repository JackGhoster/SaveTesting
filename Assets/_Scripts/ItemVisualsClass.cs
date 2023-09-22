using System;
using UnityEngine;

[Serializable]
public class ItemVisualsClass {
    public Sprite Icon;
    public string Name;
    public string Description;

    public ItemVisualsClass(Sprite icon, string name, string description) {
        Icon = icon;
        Name = name;
        Description = description;
    }
}