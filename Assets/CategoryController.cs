using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum Category
{
    C1,
    C2,
    C3,
    C4, 
    C5,
    C6,
    C7,
    C8
}

public class CategoryController : MonoBehaviour
{
    private static CategoryController _previousCategory = null;
    

    [SerializeField] private Category _category;
    [SerializeField] private CategoryPanelController _categoryPanel;

    public CategoryPanelController CategoryPanel => _categoryPanel;

    public Category category => _category;
    private Image _image;
    private void Start()
    {
        _image = GetComponent<Image>();
    }

    public void AssignImageComponent()
    {
        _image = GetComponent<Image>();
    }

    public void SelectCategory()
    {
        _previousCategory?.HideCategory();
        _categoryPanel.gameObject.SetActive(true);
        _image.color = Color.cyan;
        _previousCategory = this;
        _categoryPanel.GetComponentInChildren<Selectable>().Select();
    }

    public void HideCategory()
    {
        _image.color = Color.white;
        _categoryPanel.gameObject.SetActive(false);
    }
}
