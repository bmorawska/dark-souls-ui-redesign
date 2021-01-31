using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class CategoryPanelController : MonoBehaviour
{
    public SubcategoryController LastSubcategory;
    public Func<Item, float> Sorter;
    private List<Item> _items = new List<Item>();
    public List<InventoryItemController> _spawnedItems;
    private float _itemPanelHeight;
    [SerializeField] private GameObject _inventoryItemPrefab;
    [SerializeField] private Transform _content;
    public GameObject LastSelectedItem = null;

    public virtual void AddItem(Item item)
    {
        _items.Add(item);
    }

    public void ReselectItem()
    {
        if(LastSelectedItem != null)
            LastSelectedItem.GetComponent<Selectable>().Select();
        else
            GetComponentInChildren<Selectable>()?.Select();
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
            inventoryItemTransform.localPosition = new Vector3(0, (i) * _itemPanelHeight * -1, 0);
            InventoryItemController ic = inventoryItem.GetComponent<InventoryItemController>();
            ic.Item = item;
            ic._parentPanel = this;
            _spawnedItems.Add(ic);
        }

        var rectTransform = _content.GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x,
            _itemPanelHeight * (_spawnedItems.Count == 0 ? 1 : _spawnedItems.Count));
    }

    public virtual void SortItems()
    {
        if(_spawnedItems.Count == 0) return;
        ArrangeItems(_spawnedItems.OrderBy(i => Sorter(i.Item)).ToList());
    }

    public void ArrangeItems(List<InventoryItemController> items)
    {
        for (int i = 0; i < items.Count; i++)
        {
            items[i].transform.localPosition = new Vector3(0, (i) * _itemPanelHeight * -1, 0);
        }
    }

    public void SelectLastSubCategory()
    {
        LastSubcategory?.SelectCategory();
    }
}
