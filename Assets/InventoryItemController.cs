using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemController : MonoBehaviour
{
    //[SerializeField] private Image _itemImage;
    [SerializeField] private TextMeshProUGUI _itemNameObject;
    [SerializeField] private TextMeshProUGUI _itemDescriptionObject;
    [SerializeField] private Image _itemIcon;
    public Item Item { get; set; }

    private void Start()
    {
        _itemNameObject.text = Item.Name;
        _itemDescriptionObject.text = Item.Description;
        _itemIcon.sprite = Item.icon;
    }

    public void SelectItem()
    {
        WearableController.ChangingItem?.SetItem(Item.icon);
    }
}
