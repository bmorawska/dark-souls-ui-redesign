using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class MainInventoryPanelController : MonoBehaviour
{
    [SerializeField] private CategoryController _defaultCategory;
    [SerializeField] private Selectable _defaultSelection;

    [SerializeField] private List<Item> _allItems;
    [SerializeField] private List<Item> _c1Items;
    [SerializeField] private List<Item> _c2Items;
    [SerializeField] private List<Item> _c3Items;
    [SerializeField] private List<Item> _c4Items;
    [SerializeField] private List<Item> _c5Items;
    [SerializeField] private List<Item> _c6Items;
    [SerializeField] private List<Item> _c7Items;
    [SerializeField] private List<Item> _c8Items;
    void Start()
    {
        _defaultCategory.AssignImageComponent();
        _defaultCategory.SelectCategory();
        _defaultSelection.Select();
        
        // _c1Items.ForEach(i => i.Category = Category.C1);
        // _c2Items.ForEach(i => i.Category = Category.C2);
        // _c3Items.ForEach(i => i.Category = Category.C3);
        // _c4Items.ForEach(i => i.Category = Category.C4);
        // _c5Items.ForEach(i => i.Category = Category.C5);
        // _c6Items.ForEach(i => i.Category = Category.C6);
        // _c7Items.ForEach(i => i.Category = Category.C7);
        // _c8Items.ForEach(i => i.Category = Category.C8);
        
        _allItems.AddRange(_c1Items);
        _allItems.AddRange(_c2Items);
        _allItems.AddRange(_c3Items);
        _allItems.AddRange(_c4Items);
        _allItems.AddRange(_c5Items);
        _allItems.AddRange(_c6Items);
        _allItems.AddRange(_c7Items);
        _allItems.AddRange(_c8Items);

        
        CategoryController[] allCategoryControllers =
            FindObjectsOfType<CategoryController>().ToArray();
        for (int i = 0; i < Enum.GetNames(typeof(Category)).Length; i++)
        {
            Category category = (Category) i;
            IEnumerable<Item> categoryItems = _allItems.Where(it => it.Category == category);
            foreach (CategoryController categoryObj in allCategoryControllers.Where(c => c.category == category))
            {
                CategoryPanelController categoryPanel = categoryObj.CategoryPanel;
                if (categoryPanel.items == null)
                    categoryPanel.items = new List<Item>();
                categoryPanel.items.AddRange(categoryItems);
                categoryPanel.GenerateItems();
            }
        }
    }

}
