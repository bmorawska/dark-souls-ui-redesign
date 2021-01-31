using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponCategory
{
    Strzeleckie,
    Miecz,
    Tarcza,
    Topór,
    Włócznia
}

public enum AttackType
{
    Cięte,
    Kłute,
    Obuchowe
}
[CreateAssetMenu(fileName = "WeaponItem", menuName = "DarkSoulsUI/WeaponItem", order = 2)]
public class WeaponItem : Item
{
    public WeaponCategory WeaponCategory;
    public AttackType AttackType;
    public int Attack;
    public int Bolt;
    public int Durability;
    public int Fire;
    public int Magic;
    public int Critical;
    public int AttackFromBonus;
    public int MagicFromBonus;
    public int FireFromBonus;
    public int BoltFromBonus;
    public int CriticalFromBonus;
    
    public BonusValue StrengthBonus;
    public BonusValue AgilityBonus;
    public BonusValue IntelligenceBonus;
    public BonusValue FaithBonus;
    public float AttackReduction;
    public float MagicReduction;
    public float FireReduction;
    public float LightningReduction;
    public int Stability;
    public int StrengthRequirement;
    public int AgilityRequirement;
    public int IntelligenceRequirement;
    public int FaithRequirement;

}

public enum BonusValue
{
    Default,
    E,
    D,
    C,
    B,
    A,
    S
}
