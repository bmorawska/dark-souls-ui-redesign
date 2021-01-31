using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponCategory
{
    W1,
    W2,
    W3,
    W4,
    W5
}
[CreateAssetMenu(fileName = "WeaponItem", menuName = "DarkSoulsUI/WeaponItem", order = 2)]
public class WeaponItem : Item
{
    public WeaponCategory WeaponCategory;
    public int Attack;
    public int Bolt;
    public int Durability;
    public int Fire;
    public int Magic;
}
