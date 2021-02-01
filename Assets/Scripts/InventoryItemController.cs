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
    [SerializeField] private Sprite _inUseSpriteSelected;
    [SerializeField] private Sprite _inUseSpriteNotSelected;
    [SerializeField] private Sprite _notInUseSpriteSelected;
    [SerializeField] private Sprite _notInUseSpriteNotSelected;
    private bool _isInUse = false;
    [SerializeField] public Item Item;// { get; set; }
    [SerializeField] public GameObject visualization = null;

    private void Start()
    {
    }

    public void AssignUI()
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
        WearableController.ChangingItem?.SetItem(Item, this);
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

    public void SetNotInUse()
    {
        GetComponent<Image>().sprite = _notInUseSpriteNotSelected;
        GetComponent<Selectable>().spriteState = new SpriteState()
        {
            selectedSprite = _notInUseSpriteSelected
        };
        _isInUse = false;
    }

    public void SetInUse()
    {
        GetComponent<Image>().sprite = _inUseSpriteNotSelected;
        GetComponent<Selectable>().spriteState = new SpriteState()
        {
            selectedSprite = _inUseSpriteSelected
        };
        _isInUse = true;
    }
}
