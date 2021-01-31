using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneScriptToRuleThemAll : MonoBehaviour
{
    public void GenerateItems()
    {
        FindObjectOfType<MainInventoryPanelController>().GenerateItems();
    }
    public void SetAllScrollsValues()
    {
        foreach (ScrollRect scrollRect in FindObjectsOfType<ScrollRect>())
        {
            print(scrollRect.gameObject.name);
            scrollRect.content.anchorMin = new Vector2(0,1);
            scrollRect.content.anchorMax = new Vector2(0,1);
            scrollRect.content.position = Vector3.zero;
            scrollRect.content.sizeDelta = Vector2.one * 440; 
            scrollRect.verticalScrollbar.GetComponent<Image>().color = new Color(0,0,0,0);
            scrollRect.onValueChanged.RemoveAllListeners();
            scrollRect.onValueChanged.AddListener((v) => scrollRect.verticalScrollbar.size = 0);
            scrollRect.verticalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHide;
            scrollRect.movementType = ScrollRect.MovementType.Clamped;
            scrollRect.verticalScrollbar.transition = Selectable.Transition.None;
            scrollRect.verticalScrollbar.navigation = new Navigation(){mode = Navigation.Mode.None};
            scrollRect.horizontalScrollbar.image.color = new Color(0,0,0,0);
        }
    }

    public void AddSelectableAddonComponent()
    {
        foreach (Selectable s in FindObjectsOfType<Selectable>())
        {
            s.gameObject.AddComponent<SelectableAddon>();
        }
    }
}
