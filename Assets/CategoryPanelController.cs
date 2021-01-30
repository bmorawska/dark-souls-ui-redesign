using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

public class CategoryPanelController : MonoBehaviour
{
    public Func<Item, float> Sorter;
    private List<Item> _items = new List<Item>();
    public List<InventoryItemController> _spawnedItems;
    private float _itemPanelHeight;
    [SerializeField] private GameObject _inventoryItemPrefab;
    [SerializeField] private Transform _content;

    public virtual void AddItem(Item item)
    {
        _items.Add(item);
    }
    public virtual void GenerateItems()
    {
        _spawnedItems = new List<InventoryItemController>();
        _itemPanelHeight = _inventoryItemPrefab.GetComponent<RectTransform>().rect.height;
        for (var i = 0; i < _items.Count; i++)
        {
            Item item = _items[i];
            GameObject inventoryItem = Instantiate(_inventoryItemPrefab, _content);
            RectTransform inventoryItemTransform = inventoryItem.GetComponent<RectTransform>();
            inventoryItemTransform.localPosition = new Vector3(0, (i + 1) * _itemPanelHeight * -1, 0);
            InventoryItemController ic = inventoryItem.GetComponent<InventoryItemController>();
            ic.Item = item;
            _spawnedItems.Add(ic);
        }

        var rectTransform = _content.GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, _itemPanelHeight * _spawnedItems.Count);
    }

    public virtual void SortItems()
    {
        ArrangeItems(_spawnedItems.OrderBy(i => Sorter(i.Item)).ToList());
    }

    public void ArrangeItems(List<InventoryItemController> items)
    {
        for (int i = 0; i < items.Count; i++)
        {
            items[i].transform.localPosition = new Vector3(0, (i + 1) * _itemPanelHeight * -1, 0);
        }
    }
}
