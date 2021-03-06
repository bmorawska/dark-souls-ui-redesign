﻿using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum Category
{
    Armor,
    Weapons,
    C3,
    C4, 
    C5,
    C6,
    C7,
    C8
}

public class CategoryController : MonoBehaviour
{
    private static CategoryController _currentCategory = null;
    public static CategoryController CurrentCategory => _currentCategory;

    [SerializeField] private Category _category;
    [SerializeField] private CategoryPanelController _categoryPanel;
    //[SerializeField] private SubcategoryController _defaultSubcategory;
    [SerializeField] private Sprite CategorySprite;
    [SerializeField] private Sprite SelectedCategorySprite;
    public CategoryController CategoryUppon;
    public CategoryController CategoryBelow;
    public bool IsActive = false;// { get; protected set; } = false;

    public CategoryPanelController CategoryPanel => _categoryPanel;

    public Category category => _category;
    private Image _image;
    private void Start()
    {
        AssignImageComponent();
    }

    public void AssignImageComponent()
    {
        _image = GetComponent<Image>();
        if (CategorySprite != null)
            _image.sprite = CategorySprite;
        else
            CategorySprite = _image.sprite;
    }

    public void SelectCategory()
    {
        _currentCategory?.HideCategory();
        _categoryPanel.gameObject.SetActive(true);
        _categoryPanel.SelectLastSubCategory();
        transform.localScale = Vector3.one * 1.3f;
        _image.sprite = SelectedCategorySprite;
        _currentCategory = this;
        // _defaultSubcategory.AssignImageComponent();
        // _defaultSubcategory.SelectCategory();
        //_categoryPanel.ReselectItem();
        IsActive = true;
    }

    public void HideCategory()
    {
        _image.sprite = CategorySprite;
        transform.localScale = Vector3.one;
        _categoryPanel.gameObject.SetActive(false);
        IsActive = false;
    }
}
