using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddSpriteOnSelection : MonoBehaviour
{
    public GameObject spriteToShow;

    public void OnButtonSelected()
    {
        spriteToShow.SetActive(true);
    }
    public void OnButtonDeselected()
    {
        spriteToShow.SetActive(false);
    }
}
