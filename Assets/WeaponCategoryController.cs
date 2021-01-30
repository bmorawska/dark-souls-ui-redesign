using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class WeaponCategoryController : MonoBehaviour
{
    private static WeaponCategoryController _previousCategory = null;
    

    [SerializeField] private WeaponCategory _category;
    [SerializeField] private CategoryPanelController _categoryPanel;
    [SerializeField] private Sprite CategorySprite;
    [SerializeField] private Sprite SelectedCategorySprite;

    public CategoryPanelController CategoryPanel => _categoryPanel;

    public WeaponCategory category => _category;
    private Image _image;
    private RectTransform _rectTransform;
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
    }

    public void SelectCategory()
    {
        _previousCategory?.HideCategory();
        // GetComponent<Image>().
        _categoryPanel.gameObject.SetActive(true);
        //transform.localScale = Vector3.one * 1.3f;
        _rectTransform.sizeDelta = Vector2.one * 110;
        _image.sprite = SelectedCategorySprite;
        _previousCategory = this;
        _categoryPanel.GetComponentInChildren<Selectable>().Select();
    }

    public void HideCategory()
    {
        _rectTransform.sizeDelta = Vector2.one * 91;
        _image.sprite = CategorySprite;
        transform.localScale = Vector3.one;
        _categoryPanel.gameObject.SetActive(false);
    }
}
