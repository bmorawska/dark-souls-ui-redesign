using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SortButtonController : MonoBehaviour
{
    [SerializeField] private Sprite _ascendSprite;
    [SerializeField] private Sprite _descendSprite;
    [SerializeField] private Image _sortOrderImage;
    public void SetSortingOnWeaponCategory(int sortingID)
    {
        switch (sortingID)
        {
            case 0:
                CategoryController.CurrentCategory.CategoryPanel.Sorter = (item, dir) => 0;
                break;
            case 1:
                CategoryController.CurrentCategory.CategoryPanel.Sorter = (item, dir) => item.Weight * dir;
                break;
            case 2:
                CategoryController.CurrentCategory.CategoryPanel.Sorter = (item, dir) => item.Name.GetHashCode();
                break;
            case 3:
                CategoryController.CurrentCategory.CategoryPanel.Sorter = (item, dir) => ((WeaponItem)item).Attack * dir;
                break;
            case 4:
                CategoryController.CurrentCategory.CategoryPanel.Sorter = (item, dir) => ((WeaponItem)item).Bolt * dir;
                break;
            case 5:
                CategoryController.CurrentCategory.CategoryPanel.Sorter = (item, dir) => ((WeaponItem)item).Durability * dir;
                break;
            case 6:
                CategoryController.CurrentCategory.CategoryPanel.Sorter = (item, dir) => ((WeaponItem)item).Fire * dir;
                break;
            case 7:
                CategoryController.CurrentCategory.CategoryPanel.Sorter = (item, dir) => ((WeaponItem)item).Magic * dir;
                break;
        }
        CategoryController.CurrentCategory.CategoryPanel.SortItems();
    }
    public void SetSortingOnArmorCategory(int sortingID)
    {
        switch (sortingID)
        {
            case 0:
                CategoryController.CurrentCategory.CategoryPanel.Sorter = (item, dir) => 0;
                break;
            case 1:
                CategoryController.CurrentCategory.CategoryPanel.Sorter = (item, dir) => item.Weight * dir;
                break;
            case 2:
                CategoryController.CurrentCategory.CategoryPanel.Sorter = (item, dir) => item.Name.GetHashCode() * dir;
                break;
            case 3:
                CategoryController.CurrentCategory.CategoryPanel.Sorter = (item, dir) => ((ArmorItem)item).AttackDefence * dir;
                break;
            case 4:
                CategoryController.CurrentCategory.CategoryPanel.Sorter = (item, dir) => ((ArmorItem)item).BoltDefence * dir;
                break;
            case 5:
                CategoryController.CurrentCategory.CategoryPanel.Sorter = (item, dir) => ((ArmorItem)item).DurabilityDefence * dir;
                break;
            case 6:
                CategoryController.CurrentCategory.CategoryPanel.Sorter = (item, dir) => ((ArmorItem)item).FireDefence * dir;
                break;
            case 7:
                CategoryController.CurrentCategory.CategoryPanel.Sorter = (item, dir) => ((ArmorItem)item).MagicDefence * dir;
                break;
        }
        CategoryController.CurrentCategory.CategoryPanel.SortItems();
    }

    public void ReverseSortingOrder()
    {
        CategoryController.CurrentCategory.CategoryPanel.SortDirection *= -1;
        CategoryController.CurrentCategory.CategoryPanel.SortItems();
        _sortOrderImage.sprite = 
            CategoryController.CurrentCategory.CategoryPanel.SortDirection > 0
            ? _ascendSprite
            : _descendSprite;
    }
}
