using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FixTextMeshColor : MonoBehaviour
{
    [SerializeField] private Color _color;
    private TextMeshProUGUI _textMeshPro;

    private void Start()
    {
        GetComponent<TextMeshProUGUI>().color = _color;
    }

    public void SetColor(Color newColor)
    {
        _color = newColor;
    }
}
