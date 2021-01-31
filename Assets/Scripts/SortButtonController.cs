using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortButtonController : MonoBehaviour
{
    public void SetSortingOnSelectedCategory(int sortingID)
    {
        switch (sortingID)
        {
            case 0:
                CategoryController.CurrentCategory.CategoryPanel.Sorter = item => 0;
                break;
            case 1:
                CategoryController.CurrentCategory.CategoryPanel.Sorter = item => item.Weight;
                break;
            case 2:
                CategoryController.CurrentCategory.CategoryPanel.Sorter = item => item.Name.GetHashCode();
                break;
            case 3:
                CategoryController.CurrentCategory.CategoryPanel.Sorter = item => ((WeaponItem)item).Attack;
                break;
            case 4:
                CategoryController.CurrentCategory.CategoryPanel.Sorter = item => ((WeaponItem)item).Bolt;
                break;
            case 5:
                CategoryController.CurrentCategory.CategoryPanel.Sorter = item => ((WeaponItem)item).Durability;
                break;
            case 6:
                CategoryController.CurrentCategory.CategoryPanel.Sorter = item => ((WeaponItem)item).Fire;
                break;
            case 7:
                CategoryController.CurrentCategory.CategoryPanel.Sorter = item => ((WeaponItem)item).Magic;
                break;
        }
        CategoryController.CurrentCategory.CategoryPanel.SortItems();
    }
}
