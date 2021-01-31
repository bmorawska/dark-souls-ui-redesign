using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class SortItemController : MonoBehaviour
{
    public static SortItemController LastSortItem = null; 
    [SerializeField] private Sprite _selectedSortIcon;

    [SerializeField] private Image _imageToSetSelected;
    [SerializeField] private bool _isDefaultSort = false;

    [Header("This icon sprites")] 
    [SerializeField] private Sprite _selectedSprite;
    private Sprite _unselectedSprite;

    public void SelectSort()
    {
        _imageToSetSelected.sprite = _selectedSortIcon;
        LastSortItem.SetUnselectedSprite();
        SetSelectedSprite();
        LastSortItem = this;
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        _unselectedSprite = GetComponent<Image>().sprite;
        if (_isDefaultSort)
        {
            LastSortItem = this;
            SetSelectedSprite();
        }
    }

    public void SetSelectedSprite()
    {
        GetComponent<Image>().sprite = _selectedSprite;
        GetComponent<RectTransform>().sizeDelta = Vector2.one * 51;
    }

    public void SetUnselectedSprite()
    {
        GetComponent<Image>().sprite = _unselectedSprite;
        GetComponent<RectTransform>().sizeDelta = new Vector2(47,42);
    }
}
