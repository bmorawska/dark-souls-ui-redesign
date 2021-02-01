using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class WearableController : MonoBehaviour
{
    public static WearableController ChangingItem = null;

    [SerializeField] private Category _category;
    [SerializeField] private Image _itemIcon;
    [SerializeField] private Sprite _blankSprite;
    [SerializeField] private Sprite _slotBeeingSelected;
    public Item item = null;
    public InventoryItemController uiItem = null;
    private Sprite _defaultSprite;
    private Image _image;

    private void Start()
    {
        _image = GetComponent<Image>();
        _defaultSprite = _image.sprite;
    }

    public void SelectSlot()
    {
        ChangingItem = this;
        _image.sprite = _slotBeeingSelected;
        var allCategories = FindObjectsOfType<CategoryController>();
        foreach (var categorySlot in allCategories)
        {
            categorySlot.GetComponent<Selectable>().interactable = false;
        }
        var myCategory = allCategories.Where(c => c.category == _category).First();
        myCategory.GetComponent<Selectable>().interactable = true;
        myCategory.SelectCategory();
        myCategory.CategoryPanel.SelectLastSubCategory();
        myCategory.CategoryPanel.ReselectItem();
        foreach (WearableController wearableController in FindObjectsOfType<WearableController>())
        {
            wearableController.GetComponent<Selectable>().interactable = false;
        }
        var selectable = GetComponent<Selectable>();
        selectable.interactable = true;
    }

    public void SetItem(Item newItem, InventoryItemController newUiItem)
    {
        item = newItem;
        Sprite sprite = newItem.icon;
        foreach (WearableController wearableController in FindObjectsOfType<WearableController>())
        {
            wearableController.GetComponent<Selectable>().interactable = true;
        }
        foreach (var categorySlot in FindObjectsOfType<CategoryController>())
        {
            categorySlot.GetComponent<Selectable>().interactable = true;
        }
        _itemIcon.sprite = sprite;
        GetComponent<Selectable>().Select();
        ChangingItem = null;
        FindObjectOfType<WeightBarController>().UpdateBar();
        if (uiItem != null)
        {
            if(uiItem.visualization ?? false)
                uiItem.visualization.SetActive(false);
            uiItem.SetNotInUse();
        }
        uiItem = newUiItem;
        newUiItem.SetInUse();
        if(newUiItem.visualization ?? false)
            newUiItem.visualization.SetActive(true);
        //_defaultSprite = image.sprite;
        _image.sprite = _defaultSprite;
    }

    public void ClearItem()
    {
        if (uiItem != null)
        {
            uiItem.SetNotInUse();
            if(uiItem.visualization ?? false)
                uiItem.visualization.SetActive(false);
        }
        _itemIcon.sprite = _blankSprite;
        item = null;
        uiItem = null;
        FindObjectOfType<WeightBarController>().UpdateBar();
    }
}
