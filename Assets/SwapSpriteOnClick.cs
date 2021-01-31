using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwapSpriteOnClick : MonoBehaviour
{
    [SerializeField] private GameObject button;
    [SerializeField] private Sprite defaultSprite;
    [SerializeField] private Sprite otherSprite;
    [SerializeField] private GameObject panel;
    private int currentSprite = 0;

    public void SwapSprites()
    {
        if (currentSprite == 0)
        {
            button.GetComponent<Image>().sprite = otherSprite;
            currentSprite = 1;
            panel.SetActive(true);
            return;
        }
        if (currentSprite == 1)
        {
            button.GetComponent<Image>().sprite = defaultSprite;
            currentSprite = 0;
            panel.SetActive(false);
        }
    }
}
