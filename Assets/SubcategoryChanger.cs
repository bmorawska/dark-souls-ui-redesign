using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubcategoryChanger : MonoBehaviour
{
    private CategoryController _categoryController;
    // Start is called before the first frame update
    void Start()
    {
        _categoryController = GetComponent<CategoryController>();
    }

    private void Update()
    {
        if (!_categoryController.IsActive)
            return;
        switch (SelectableAddon.CurrentType)
        {
            case SelectableAddon.SelectionType.Default:
                break;
            case SelectableAddon.SelectionType.Item:
                if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    var previousCategory = SubcategoryController._activeCategory?._previousCategory;
                    if(!Input.GetKey(KeyCode.LeftControl) && previousCategory != null)
                        previousCategory.SelectCategory();
                    else
                        GetComponent<Selectable>().Select();
                }
                if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
                    SubcategoryController._activeCategory?._nextCategory?.SelectCategory();
                break;
            case SelectableAddon.SelectionType.MainCategory:
                // if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
                //     _categoryController.CategoryBelow?.SelectCategory();
                // if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
                //     _categoryController.CategoryUppon?.SelectCategory();
                if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
                    _categoryController.CategoryPanel.ReselectItem();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
