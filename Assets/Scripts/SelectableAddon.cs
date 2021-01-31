using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelectableAddon : MonoBehaviour, ISelectHandler, IDeselectHandler, IPointerClickHandler
{
    public static SelectableAddon LastSelectedWearableItem = null; 
    public enum SelectionType
    {
        Default,
        Item,
        MainCategory,
        WearableItem
    }
    static public SelectableAddon CurrentSelected = null;
    static public SelectionType CurrentType = SelectionType.Default;
    public SelectionType elementType = SelectionType.Default;
    private bool isSelected = false;
    public void OnPointerClick(PointerEventData eventData)
    {
        // print("clicked");
        // if (isSelected)
        //     GetComponent<EventTrigger>().OnSubmit(null);
        // else
        //     isSelected = true;
    }
    public void OnSelect(BaseEventData eventData)
    {
        //if(eventData.currentInputModule.input.mousePresent)
        //print("selected");
        CurrentSelected = this;
        CurrentType = elementType;
        if (elementType == SelectionType.WearableItem)
            LastSelectedWearableItem = this;
    }

    // private void Update()
    // {
    //     if(isSelected2)
    //         GetComponent<EventTrigger>().OnSubmit(null);
    // }

    public void OnDeselect(BaseEventData eventData)
    {
        isSelected = false;
    }
}
