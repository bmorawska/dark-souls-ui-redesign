using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputController : MonoBehaviour
{
    [SerializeField] private DescriptionPanelController _descriptionPanel;
    [SerializeField] private GameObject _sortPanel;
    [SerializeField] private Button _sortButton;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I) && SelectableAddon.CurrentType == SelectableAddon.SelectionType.Item)
        {
            _descriptionPanel.gameObject.SetActive(true);
            //set values
        }

        if (Input.GetKeyDown(KeyCode.Q) && _sortButton.interactable)
        {
            _sortPanel.SetActive(true);
            // select current sort button
        }
            
        switch (SelectableAddon.CurrentType)
        {
            case SelectableAddon.SelectionType.Default:
                break;
            case SelectableAddon.SelectionType.Item:
            {
                var active = SubcategoryController._activeCategory;
                bool isWrongCategory = active != null &&
                                      active.category != SelectableAddon.CurrentSelected
                                          .GetComponent<InventoryItemController>().Item.Category;
                if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    var previousCategory = SubcategoryController._activeCategory._previousCategory;
                    if (Input.GetKey(KeyCode.LeftControl) || previousCategory == null || isWrongCategory)
                        CategoryController.CurrentCategory.GetComponent<Selectable>().Select();
                    else
                    {
                        print("Changed subcategory to left");
                        previousCategory.SelectCategory();
                        previousCategory.CategoryPanel.ReselectItem();
                    }
                }

                if (isWrongCategory) return;
                if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
                {
                    var nextCategory = SubcategoryController._activeCategory._nextCategory;
                    if (nextCategory != null)
                    {
                        print("Changed subcategory to right");
                        nextCategory.SelectCategory();
                        nextCategory.CategoryPanel.ReselectItem();
                    }
                }
                break;
            }
            case SelectableAddon.SelectionType.MainCategory:
                // if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
                //     _categoryController.CategoryBelow?.SelectCategory();
                // if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
                //     _categoryController.CategoryUppon?.SelectCategory();
                if (Input.GetKeyDown(KeyCode.D) 
                    || Input.GetKeyDown(KeyCode.RightArrow) 
                    || Input.GetKeyDown(KeyCode.Return))
                {
                    print("Went to item on right");
                    CategoryController.CurrentCategory.CategoryPanel.ReselectItem();
                }
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
            
    }
}
