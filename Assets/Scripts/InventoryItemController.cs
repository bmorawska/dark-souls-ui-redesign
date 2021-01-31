using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryItemController : MonoBehaviour
{
    public CategoryPanelController _parentPanel;
    [SerializeField] private Color _defaultColor;
    //[SerializeField] private Image _itemImage;
    [SerializeField] private TextMeshProUGUI _itemNameObject;
    //[SerializeField] private TextMeshProUGUI _itemDescriptionObject;
    [SerializeField] private Image _itemIcon;
    [SerializeField] private GameObject _countBackground;
    [SerializeField] private TextMeshProUGUI _countText;
    [SerializeField] private TextMeshProUGUI _descriptionText = null;
    [SerializeField] private GameObject _defaultIcons = null;
    [SerializeField] private GameObject _selectedIcons = null;
    
    public Item Item { get; set; }

    private void Start()
    {
        _itemNameObject.text = Item.Name;
        if (Item.Count == 0 || Item.Count == 1)
            _countBackground.SetActive(false);
        else
            _countText.text = Item.Count.ToString();
        if (_descriptionText != null)
            _descriptionText.text = Item.Description;
        //_itemDescriptionObject.text = Item.Description;
        _itemIcon.sprite = Item.icon;
        CategoryItemsAssigment assigment = GetComponent<CategoryItemsAssigment>();
        assigment?.AssignItem(Item);
    }

    
    private void OnEnable()
    {
        GetComponent<EventTrigger>().OnDeselect(null);
    }

    public void ChooseItem()
    {
        WearableController.ChangingItem?.SetItem(Item);
    }

    public void SelectItem()
    {
        ChangeChildrenTextColorBlack();
        _parentPanel.LastSelectedItem = gameObject;
    }
    
    public void ChangeChildrenTextColorBlack()
    {
        foreach (TextMeshProUGUI text in GetComponentsInChildren<TextMeshProUGUI>())
        {
            if(text != _countText)
                text.color = Color.black;
        }
        _selectedIcons?.SetActive(true);
        _defaultIcons?.SetActive(false);
    }

    public void ChangeChildrenTextColorDefault()
    {
        foreach (TextMeshProUGUI text in GetComponentsInChildren<TextMeshProUGUI>())
        {
            text.color = _defaultColor;
        }
        _selectedIcons?.SetActive(false);
        _defaultIcons?.SetActive(true);
    }
}
