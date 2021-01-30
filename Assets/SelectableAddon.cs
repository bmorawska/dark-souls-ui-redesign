using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelectableAddon : MonoBehaviour, ISelectHandler
{
    public enum SelectionType
    {
        Default,
        Item,
        MainCategory
    }
    static public SelectableAddon CurrentSelected = null;
    static public SelectionType CurrentType = SelectionType.Default;
    public SelectionType elementType = SelectionType.Default;

    public void OnSelect(BaseEventData eventData)
    {
        CurrentSelected = this;
        CurrentType = elementType;
    }
}
