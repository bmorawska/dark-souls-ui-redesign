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
        if (!_categoryController.IsActive || !SelectableAddon.IsItemSelected)
            return;
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
    }
}
