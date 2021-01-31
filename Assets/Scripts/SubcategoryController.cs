using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class SubcategoryController : MonoBehaviour
{
    public static SubcategoryController _activeCategory = null;

    [SerializeField] private CategoryPanelController _parent;
    //[SerializeField] private WeaponCategory _category;
    [SerializeField] private CategoryPanelController _categoryPanel;
    [SerializeField] private Sprite CategorySprite;
    [SerializeField] private Sprite SelectedCategorySprite;
    public Category category;// { get; set; }

    public CategoryPanelController CategoryPanel => _categoryPanel;

    //public WeaponCategory category => _category;
    private Image _image;
    private RectTransform _rectTransform;

    public SubcategoryController _nextCategory;
    public SubcategoryController _previousCategory;
    private bool _wasAssigned = false;

    private void Start()
    {
        AssignImageComponent();
    }

    public void AssignImageComponent()
    {
        _rectTransform = GetComponent<RectTransform>();
        _image = GetComponent<Image>();
        if (CategorySprite != null)
            _image.sprite = CategorySprite;
        else
            CategorySprite = _image.sprite;
        _wasAssigned = true;
    }

    public void SelectCategory()
    {
        if (_activeCategory != null && _activeCategory.category == this.category)
            _activeCategory.HideCategory();
        _activeCategory = this;
        // GetComponent<Image>().
        _categoryPanel.gameObject.SetActive(true);
        //_categoryPanel.ReselectItem();
        //transform.localScale = Vector3.one * 1.3f;
        _parent.LastSubcategory = this;
        if(!_wasAssigned)
            AssignImageComponent();
        _rectTransform.sizeDelta = Vector2.one * 110;
        _image.sprite = SelectedCategorySprite;
        transform.SetAsLastSibling();
    }

    public void HideCategory()
    {
        _rectTransform.sizeDelta = Vector2.one * 91;
        _image.sprite = CategorySprite;
        transform.localScale = Vector3.one;
        _categoryPanel.gameObject.SetActive(false);
    }
}
