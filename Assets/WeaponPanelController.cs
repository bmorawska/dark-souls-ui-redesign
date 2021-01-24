using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WeaponPanelController : CategoryPanelController
{
    //delegate float Sorter(WeaponItem item);

    [SerializeField] private CategoryPanelController _w1;
    [SerializeField] private CategoryPanelController _w2;
    [SerializeField] private CategoryPanelController _w3;
    [SerializeField] private CategoryPanelController _w4;
    [SerializeField] private CategoryPanelController _w5;
    [SerializeField] private WeaponCategoryController _defaultCategory;
    private void Start()
    {
        _defaultCategory.AssignImageComponent();
        _defaultCategory.SelectCategory();
        Sorter = (item) => 0;
    }

    public override void AddItem(Item item)
    {
        WeaponItem wItem = (WeaponItem) item;
        switch (wItem.WeaponCategory)
        {
            case WeaponCategory.W1:
                _w1.AddItem(item);
                break;
            case WeaponCategory.W2:
                _w2.AddItem(item);
                break;
            case WeaponCategory.W3:
                _w3.AddItem(item);
                break;
            case WeaponCategory.W4:
                _w4.AddItem(item);
                break;
            case WeaponCategory.W5:
                _w5.AddItem(item);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public override void GenerateItems()
    {
        _w1.GenerateItems();
        _w2.GenerateItems();
        _w3.GenerateItems();
        _w4.GenerateItems();
        _w5.GenerateItems();
    }

    public override void SortItems()
    {
        _w1.ArrangeItems(_w1._spawnedItems.OrderBy(i => Sorter(i.Item)).ToList());
        _w2.ArrangeItems(_w2._spawnedItems.OrderBy(i => Sorter(i.Item)).ToList());
        _w3.ArrangeItems(_w3._spawnedItems.OrderBy(i => Sorter(i.Item)).ToList());
        _w4.ArrangeItems(_w4._spawnedItems.OrderBy(i => Sorter(i.Item)).ToList());
        _w5.ArrangeItems(_w5._spawnedItems.OrderBy(i => Sorter(i.Item)).ToList());
    }
}
