using System;

[Serializable]
public class Item 
{
    public StatClass Stat;
    public ItemVisualsClass Visuals;
    public bool Equipped;
    public Item(StatSO statSO, ItemVisualsSO visualsSO) {
        Stat = new StatClass(statSO.Id, statSO.Amount);
        Visuals = new ItemVisualsClass(visualsSO.Icon, visualsSO.Name, visualsSO.Description);
        Equipped = false;
    }

   
}
