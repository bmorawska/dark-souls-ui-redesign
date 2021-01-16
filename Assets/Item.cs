using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Item", menuName = "DarkSoulsUI/Item", order = 1)]
public class Item : ScriptableObject
{
    public Sprite icon;
    public Category Category;
    public string Name;
    public string Description;
    public float Weight;
    public int Count;
}
