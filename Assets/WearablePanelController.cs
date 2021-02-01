using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WearablePanelController : MonoBehaviour
{
    [SerializeField] private Sprite _selectedPanelSprite;
    [SerializeField] private List<GameObject> _objectsOnSelected;
    [SerializeField] private List<GameObject> _objectsOnNotSelected;
    private Sprite _defaultPanelSprite;
    // Start is called before the first frame update
    void Start()
    {
        _defaultPanelSprite = GetComponent<Image>().sprite;
    }

    public void ChangeToSelected()
    {
        GetComponent<Image>().sprite = _selectedPanelSprite;
        foreach (GameObject go in _objectsOnSelected)
            go.SetActive(true);
        foreach (GameObject go in _objectsOnNotSelected)
            go.SetActive(false);
    }
    public void ChangeToNotSelected()
    {
        GetComponent<Image>().sprite = _defaultPanelSprite;
        foreach (GameObject go in _objectsOnSelected)
            go.SetActive(false);
        foreach (GameObject go in _objectsOnNotSelected)
            go.SetActive(true);
    }
}
