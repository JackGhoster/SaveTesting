using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
    [SerializeField] private Image _icon;
    [SerializeField] private TextMeshProUGUI _name, _amount;

    public void Build(Sprite icon, string name,string stat,string amount) {
        _icon.sprite = icon;
        _name.text = name;
        _amount.text = $"{stat} Amount: {amount}";
    }
}
