using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelectChosenCategory : MonoBehaviour
{
    public void SelectCategory()
    {
        //print("selecting current category");
        //CategoryController.CurrentCategory.GetComponent<EventTrigger>().OnSubmit(null);
        _isSelected = true;
    }

    private bool _isSelected = false;

    private void Update()
    {
        if (_isSelected)
        {
            CategoryController.CurrentCategory.GetComponent<Selectable>().Select();
            _isSelected = false;
        }
    }
}
