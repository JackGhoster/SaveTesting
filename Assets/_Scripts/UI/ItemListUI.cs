using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemListUI : MonoBehaviour
{
    [SerializeField] private ItemUI _prefab;

    private void Start() {
        Invoke(nameof(Populate), 1f);
    }

    private void Populate() {
        var inventory =  SaveSystem.Instance.LoadInventory();
        for (int i = 0; i < inventory.Items.Count; i++) {
            Item item = inventory.Items[i];
            print($"{i}Item Visuals - Name:{item.Visuals.Name}, Description:{item.Visuals.Description}");
            print($"{i}Item stats - StatId:{item.Stat.Id}, Amount:{item.Stat.Amount}");
            var itemUI = Instantiate(_prefab, transform);
            itemUI.Build(
                icon: item.Visuals.Icon,
                name: item.Visuals.Name,
                stat: item.Stat.Id.ToString(),
                amount: item.Stat.Amount.ToString()
                );
        }
    }
}
