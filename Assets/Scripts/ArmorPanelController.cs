using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ArmorPanelController : CategoryPanelController
{
    //delegate float Sorter(WeaponItem item);
    [SerializeField] private CategoryPanelController _w1;
    [SerializeField] private CategoryPanelController _w2;
    [SerializeField] private CategoryPanelController _w3;
    [SerializeField] private CategoryPanelController _w4;
    [SerializeField] private SubcategoryController _defaultCategory;
    private void Start()
    {
        _defaultCategory.AssignImageComponent();
        _defaultCategory.SelectCategory();
        Sorter = (item) => 0;
    }

    public override void AddItem(Item item)
    {
        ArmorItem wItem = (ArmorItem) item;
        switch (wItem.ArmorCategory)
        {
            case ArmorCategory.A1:
                _w1.AddItem(item);
                break;
            case ArmorCategory.A2:
                _w2.AddItem(item);
                break;
            case ArmorCategory.A3:
                _w3.AddItem(item);
                break;
            case ArmorCategory.A4:
                _w4.AddItem(item);
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
    }

    public override void SortItems()
    {
        _w1.ArrangeItems(_w1._spawnedItems.OrderBy(i => Sorter(i.Item)).ToList());
        _w2.ArrangeItems(_w2._spawnedItems.OrderBy(i => Sorter(i.Item)).ToList());
        _w3.ArrangeItems(_w3._spawnedItems.OrderBy(i => Sorter(i.Item)).ToList());
        _w4.ArrangeItems(_w4._spawnedItems.OrderBy(i => Sorter(i.Item)).ToList());
    }
}
