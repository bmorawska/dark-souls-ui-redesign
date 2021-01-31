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

    public void SelectSlot()
    {
        ChangingItem = this;
        var allCategories = FindObjectsOfType<CategoryController>();
        foreach (var categorySlot in allCategories)
        {
            categorySlot.GetComponent<Selectable>().interactable = false;
        }
        var myCategory = allCategories.Where(c => c.category == _category).First();
        myCategory.GetComponent<Selectable>().interactable = true;
        myCategory.SelectCategory();
        foreach (WearableController wearableController in FindObjectsOfType<WearableController>())
        {
            wearableController.GetComponent<Selectable>().interactable = false;
        }
    }

    public void SetItem(Sprite sprite)
    {
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
    }
}
