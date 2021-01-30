using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelectableAddon : MonoBehaviour, ISelectHandler
{
    static public SelectableAddon CurrentSelected = null;
    static public bool IsItemSelected = false;
    public bool IsItem = false;

    public void OnSelect(BaseEventData eventData)
    {
        CurrentSelected = this;
        IsItemSelected = IsItem;
    }
}
