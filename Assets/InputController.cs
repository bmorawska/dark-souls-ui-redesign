using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputController : MonoBehaviour
{
    [SerializeField] private DescriptionPanelController _descriptionPanel;
    [SerializeField] private GameObject _sortPanel;
    [SerializeField] private Button _sortButton;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I) && SelectableAddon.CurrentType == SelectableAddon.SelectionType.Item)
        {
            _descriptionPanel.gameObject.SetActive(true);
            //set values
        }

        if (Input.GetKeyDown(KeyCode.Q) && _sortButton.interactable)
        {
            _sortPanel.SetActive(true);
            // select current sort button
        }
            
            
    }
}
