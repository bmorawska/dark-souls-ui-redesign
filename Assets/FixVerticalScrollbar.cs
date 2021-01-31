using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FixVerticalScrollbar : MonoBehaviour
{
    private Scrollbar _scrollbar;
    // Start is called before the first frame update
    void Start()
    {
        _scrollbar = GetComponent<Scrollbar>();
        _scrollbar.size = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        _scrollbar.size = 0.1f;
    }
}
