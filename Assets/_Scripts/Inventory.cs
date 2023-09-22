using System;
using System.Collections.Generic;

[Serializable]
public class Inventory {
    public List<Item> Items;
    public Inventory(List<Item> items)
    {
        Items = items;
    }
}