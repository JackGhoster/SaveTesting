using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveSystem : MonoBehaviour {
    public static SaveSystem Instance;
    [field: SerializeField] public string Json { get; private set; }
    private void Awake() {
        Instance = this;
    }

    public void SaveInventory(Inventory inventory) {
        Json = JsonUtility.ToJson(inventory);
        Debug.Log($"Saved: {Json}");
    }
    
    public Inventory LoadInventory() {
        var json = JsonUtility.FromJson<Inventory>(Json);

        return json;
    }

}