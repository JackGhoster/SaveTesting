using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] private StatContainer _statContainer;
    [SerializeField] private ItemVisualsContainer _visualsContainer;
    [SerializeField] private List<Item> _items;

    // Start is called before the first frame update
    void Start()
    {
        _items.Add(CreateItem());
        _items.Add(CreateItem());
        _items.Add(CreateItem());
        _items.Add(CreateItem());

        Inventory inventory = new Inventory(_items);

        SaveSystem.Instance.SaveInventory(inventory);
    }

    private Item CreateItem() {
        var randomStat = _statContainer.Stats[Random.Range(0, _statContainer.Stats.Count)];
        var randomVisuals = _visualsContainer.Visuals[Random.Range(0, _visualsContainer.Visuals.Count)];

        return new Item(randomStat, randomVisuals);
    }


}
