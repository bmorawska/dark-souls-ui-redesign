using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CategoryPanelController : MonoBehaviour
{
    [FormerlySerializedAs("_items")] public List<Item> items;
    [SerializeField] private GameObject _inventoryItemPrefab;
    [SerializeField] private Transform _content;
    public void GenerateItems()
    {
        for (var i = 0; i < items.Count; i++)
        {
            Item item = items[i];
            GameObject inventoryItem = Instantiate(_inventoryItemPrefab, _content);
            RectTransform inventoryItemTransform = inventoryItem.GetComponent<RectTransform>();
            inventoryItemTransform.localPosition = new Vector3(0, (i + 1) * inventoryItemTransform.rect.height * -1, 0);
            inventoryItem.GetComponent<InventoryItemController>().Item = item;
        }
    }
}
