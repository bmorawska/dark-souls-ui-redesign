using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ArmorCategory
{
    A1,
    A2,
    A3,
    A4
}
[CreateAssetMenu(fileName = "ArmorItem", menuName = "DarkSoulsUI/ArmorItem", order = 3)]
public class ArmorItem : Item
{
    public ArmorCategory ArmorCategory;
    public int Bolt;
    public int Durability;
    public int Fire;
    public int Magic;
}
