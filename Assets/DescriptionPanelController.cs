using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DescriptionPanelController : MonoBehaviour
{
    public void SetAllValues(WeaponItem weapon, WeaponItem previousWeapon)
    {
        SetWeaponName(weapon.Name);
        SetAttackType(weapon.AttackType.ToString());
        SetWeaponType(weapon.WeaponCategory.ToString());
        
        //obrazenia
        SetObrazeniaFizyczneValue(weapon.Attack);
        SetObrazeniaMagiczneValue(weapon.Magic);
        SetObrazeniaOgnisteValue(weapon.Fire);
        SetObrazeniaBlyskValue(weapon.Bolt);
        SetObrazeniaKrytyczneValue(weapon.Critical);
        
        SetBonusAtakFizyczne(weapon.AttackFromBonus);
        SetBonusAtakMagiczne(weapon.MagicFromBonus);
        SetBonusAtakOgniste(weapon.FireFromBonus);
        SetBonusAtakBlysk(weapon.BoltFromBonus);
        SetBonusAtakKrytyczne(weapon.CriticalFromBonus);
        
        SetComparAtakFizyczne((weapon.Attack + weapon.AttackFromBonus) - previousWeapon.Attack);
        SetComparAtakMagiczne((weapon.Magic + weapon.MagicFromBonus) - previousWeapon.Magic);
        SetComparAtakOgniste((weapon.Fire + weapon.FireFromBonus) - previousWeapon.Fire);
        SetComparAtakBlysk((weapon.Bolt + weapon.BoltFromBonus) - previousWeapon.Bolt);
        SetComparAtakKrytyczne((weapon.Critical + weapon.CriticalFromBonus) - previousWeapon.Critical);
        
        SetBonusStrength(weapon.StrengthBonus, weapon.StrengthBonus - previousWeapon.StrengthBonus);
        SetBonusAgility(weapon.AgilityBonus, weapon.AgilityBonus - previousWeapon.AgilityBonus);
        SetBonusIntelligence(weapon.IntelligenceBonus, weapon.IntelligenceBonus - previousWeapon.IntelligenceBonus);
        SetBonusFaith(weapon.FaithBonus, weapon.FaithBonus - previousWeapon.FaithBonus);
        
        
        
        //redukcja DUN
        SetRedukcjaFizyczneValue(weapon.AttackReduction);
        SetRedukcjaMagiczneValue(weapon.MagicReduction);
        SetRedukcjaOgnisteValue(weapon.FireReduction);
        SetRedukcjaBlyskValue(weapon.LightningReduction);
        SetComparRedukcjaStabilnosc(weapon.Stability);
        
        SetComparRedukcjaFizyczne(weapon.AttackReduction - previousWeapon.AttackReduction);
        SetComparRedukcjaMagiczne(weapon.MagicReduction - previousWeapon.MagicReduction);
        SetComparRedukcjaOgniste(weapon.FireReduction - previousWeapon.FireReduction);
        SetComparRedukcjaBlysk(weapon.LightningReduction - previousWeapon.LightningReduction);
        SetComparRedukcjaStabilnosc(weapon.Stability - previousWeapon.Stability);
        
        //wymagania DUN    
        SetWymagSilaValue(weapon.StrengthRequirement);
        SetWymagZrecznoscValue(weapon.AgilityRequirement);
        SetWymagInteligencjaValue(weapon.IntelligenceRequirement);
        SetWymagWiaraValue(weapon.FaithRequirement);
        SetWymagWytrzymValue(weapon.Durability);
        SetWymagUdzwigValue(weapon.Weight);
        SetComparWymagUdzwig(weapon.Weight - previousWeapon.Weight);
        
        
    }
    
    
    
    [Space(10)]
    [Header("Ogolne")]
    [Space(10)]
    
    [SerializeField]
    private GameObject WeaponName;
    [SerializeField]
    private GameObject AttackType;
    [SerializeField]
    private GameObject WeaponType;

    private void SetWeaponName(string name)
    {
        WeaponName.GetComponent<TextMeshProUGUI>().text = name;
    }
    private void SetAttackType(string type)
    {
        AttackType.GetComponent<TextMeshProUGUI>().text = "Rodzaj ataku: <u>" + type + "</u>";
    }
    private void SetWeaponType(string type)
    {
        WeaponType.GetComponent<TextMeshProUGUI>().text = "Rodzaj broni: <u>" + type + "</u>";
    }

    #region atakObrazenia
    
    [Space(10)]
    [Header("Obrazenia")]
    [Space(10)]
    
    [SerializeField]
    private GameObject ObrazeniaFizyczneValue;
    [SerializeField]
    private GameObject ObrazeniaMagiczneValue;
    [SerializeField]
    private GameObject ObrazeniaOgnisteValue;
    [SerializeField]
    private GameObject ObrazeniaBlyskValue;
    [SerializeField]
    private GameObject ObrazeniaKrytyczneValue;

    private void SetObrazeniaFizyczneValue(int value)
    {
        ObrazeniaFizyczneValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    private void SetObrazeniaMagiczneValue(int value)
    {
        ObrazeniaMagiczneValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    private void SetObrazeniaOgnisteValue(int value)
    {
        ObrazeniaOgnisteValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    private void SetObrazeniaBlyskValue(int value)
    {
        ObrazeniaBlyskValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    private void SetObrazeniaKrytyczneValue(int value)
    {
        ObrazeniaKrytyczneValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    
    [Space(10)]
    [Header("Porownania obrazenia")]
    [Space(10)]
    
    [SerializeField]
    private GameObject ComparAtakFizyczne;
    [SerializeField]
    private GameObject ComparAtakMagiczne;
    [SerializeField]
    private GameObject ComparAtakOgniste;
    [SerializeField]
    private GameObject ComparAtakBlysk;
    [SerializeField]
    private GameObject ComparAtakKrytyczne;

    private void SetComparAtakFizyczne(int comparedValue)
    {
        if (comparedValue > 0)
        {
            ComparAtakFizyczne.SetActive(true);
            ComparAtakFizyczne.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=#00ffffff>+" + comparedValue.ToString() + "</color>" + ")";
        }
        else if(comparedValue < 0)
        {
            ComparAtakFizyczne.SetActive(true);
            ComparAtakFizyczne.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=red>" + comparedValue.ToString() + "</color>" + ")";
        }
        else
        {
            ComparAtakFizyczne.SetActive(false);
        }
    }
    
    private void SetComparAtakMagiczne(int comparedValue)
    {
        if (comparedValue > 0)
        {
            ComparAtakMagiczne.SetActive(true);
            ComparAtakMagiczne.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=#00ffffff>+" + comparedValue.ToString() + "</color>" + ")";
        }
        else if(comparedValue < 0)
        {
            ComparAtakMagiczne.SetActive(true);
            ComparAtakMagiczne.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=red>" + comparedValue.ToString() + "</color>" + ")";
        }
        else
        {
            ComparAtakMagiczne.SetActive(false);
        }
    }
    
    private void SetComparAtakOgniste(int comparedValue)
    {
        if (comparedValue > 0)
        {
            ComparAtakOgniste.SetActive(true);
            ComparAtakOgniste.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=#00ffffff>+" + comparedValue.ToString() + "</color>" + ")";
        }
        else if(comparedValue < 0)
        {
            ComparAtakOgniste.SetActive(true);
            ComparAtakOgniste.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=red>" + comparedValue.ToString() + "</color>" + ")";
        }
        else
        {
            ComparAtakOgniste.SetActive(false);
        }
    }
    
    private void SetComparAtakBlysk(int comparedValue)
    {
        if (comparedValue > 0)
        {
            ComparAtakBlysk.SetActive(true);
            ComparAtakBlysk.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=#00ffffff>+" + comparedValue.ToString() + "</color>" + ")";
        }
        else if(comparedValue < 0)
        {
            ComparAtakBlysk.SetActive(true);
            ComparAtakBlysk.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=red>" + comparedValue.ToString() + "</color>" + ")";
        }
        else
        {
            ComparAtakBlysk.SetActive(false);
        }
    }
    
    private void SetComparAtakKrytyczne(int comparedValue)
    {
        if (comparedValue > 0)
        {
            ComparAtakKrytyczne.SetActive(true);
            ComparAtakKrytyczne.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=#00ffffff>+" + comparedValue.ToString() + "</color>" + ")";
        }
        else if(comparedValue < 0)
        {
            ComparAtakKrytyczne.SetActive(true);
            ComparAtakKrytyczne.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=red>" + comparedValue.ToString() + "</color>" + ")";
        }
        else
        {
            ComparAtakKrytyczne.SetActive(false);
        }
    }
    
    [Space(10)]
    [Header("Obrazenia bonusy")]
    [Space(10)]
    [SerializeField]
    private GameObject BonusAtakFizyczne;
    [SerializeField]
    private GameObject BonusAtakMagiczne;
    [SerializeField]
    private GameObject BonusAtakOgniste;
    [SerializeField]
    private GameObject BonusAtakBlysk;
    [SerializeField]
    private GameObject BonusAtakKrytyczne;

    private void SetBonusAtakFizyczne(int value)
    {
        if (value > 0)
        {
            BonusAtakFizyczne.SetActive(true);
            BonusAtakFizyczne.GetComponent<TextMeshProUGUI>().text = "+" + value.ToString();
        }
        else if (value < 0)
        {
            BonusAtakFizyczne.SetActive(true);
            BonusAtakFizyczne.GetComponent<TextMeshProUGUI>().text = value.ToString();
        }
        else
        {
            BonusAtakFizyczne.SetActive(false);
        }
    }
    private void SetBonusAtakMagiczne(int value)
    {
        if (value > 0)
        {
            BonusAtakMagiczne.SetActive(true);
            BonusAtakMagiczne.GetComponent<TextMeshProUGUI>().text = "+" + value.ToString();
        }
        else if (value < 0)
        {
            BonusAtakMagiczne.SetActive(true);
            BonusAtakMagiczne.GetComponent<TextMeshProUGUI>().text = value.ToString();
        }
        else
        {
            BonusAtakMagiczne.SetActive(false);
        }
    }
    private void SetBonusAtakOgniste(int value)
    {
        if (value > 0)
        {
            BonusAtakOgniste.SetActive(true);
            BonusAtakOgniste.GetComponent<TextMeshProUGUI>().text = "+" + value.ToString();
        }
        else if (value < 0)
        {
            BonusAtakOgniste.SetActive(true);
            BonusAtakOgniste.GetComponent<TextMeshProUGUI>().text = value.ToString();
        }
        else
        {
            BonusAtakOgniste.SetActive(false);
        }
    }
    private void SetBonusAtakBlysk(int value)
    {
        if (value > 0)
        {
            BonusAtakBlysk.SetActive(true);
            BonusAtakBlysk.GetComponent<TextMeshProUGUI>().text = "+" + value.ToString();
        }
        else if (value < 0)
        {
            BonusAtakBlysk.SetActive(true);
            BonusAtakBlysk.GetComponent<TextMeshProUGUI>().text = value.ToString();
        }
        else
        {
            BonusAtakBlysk.SetActive(false);
        }
    }
    private void SetBonusAtakKrytyczne(int value)
    {
        if (value > 0)
        {
            BonusAtakKrytyczne.SetActive(true);
            BonusAtakKrytyczne.GetComponent<TextMeshProUGUI>().text = "+" + value.ToString();
        }
        else if (value < 0)
        {
            BonusAtakKrytyczne.SetActive(true);
            BonusAtakKrytyczne.GetComponent<TextMeshProUGUI>().text = value.ToString();
        }
        else
        {
            BonusAtakKrytyczne.SetActive(false);
        }
    }
    
    [Space(10)]
    [Header("Premie od parametrow")]
    [Space(10)]
    [SerializeField]
    private GameObject BonusStrength;
    [SerializeField]
    private GameObject BonusAgility;
    [SerializeField]
    private GameObject BonusIntelligence;
    [SerializeField]
    private GameObject BonusFaith;

    private void SetBonusStrength(BonusValue value, int comparison)
    {
        string valueString = value.ToString();
        if (value == BonusValue.Default)
            valueString = "-";
        if (comparison > 0)
            BonusStrength.GetComponent<TextMeshProUGUI>().text = "<color = #00ffffff>" + valueString + "</color>";
        else if(comparison < 0)
            BonusStrength.GetComponent<TextMeshProUGUI>().text = "<color = red>" + valueString + "</color>";
        else 
            BonusStrength.GetComponent<TextMeshProUGUI>().text = valueString;
    }
    private void SetBonusAgility(BonusValue value, int comparison)
    {
        string valueString = value.ToString();
        if (value == BonusValue.Default)
            valueString = "-";
        if (comparison > 0)
            BonusAgility.GetComponent<TextMeshProUGUI>().text = "<color = #00ffffff>" + valueString + "</color>";
        else if(comparison < 0)
            BonusAgility.GetComponent<TextMeshProUGUI>().text = "<color = red>" + valueString + "</color>";
        else 
            BonusAgility.GetComponent<TextMeshProUGUI>().text = valueString;
    }
    private void SetBonusIntelligence(BonusValue value, int comparison)
    {
        string valueString = value.ToString();
        if (value == BonusValue.Default)
            valueString = "-";
        if (comparison > 0)
            BonusIntelligence.GetComponent<TextMeshProUGUI>().text = "<color = #00ffffff>" + valueString + "</color>";
        else if(comparison < 0)
            BonusIntelligence.GetComponent<TextMeshProUGUI>().text = "<color = red>" + valueString + "</color>";
        else 
            BonusIntelligence.GetComponent<TextMeshProUGUI>().text = valueString;
    }
    private void SetBonusFaith(BonusValue value, int comparison)
    {
        string valueString = value.ToString();
        if (value == BonusValue.Default)
            valueString = "-";
        if (comparison > 0)
            BonusFaith.GetComponent<TextMeshProUGUI>().text = "<color = #00ffffff>" + valueString + "</color>";
        else if(comparison < 0)
            BonusFaith.GetComponent<TextMeshProUGUI>().text = "<color = red>" + valueString + "</color>";
        else 
            BonusFaith.GetComponent<TextMeshProUGUI>().text = valueString;
    }
    
    
    
    
    #endregion atakObrazenia

    #region redukcja
    
    [Space(10)]
    [Header("Redukcja")]
    [Space(10)]
    [SerializeField]
    private GameObject RedukcjaFizyczneValue;
    [SerializeField]
    private GameObject RedukcjaMagiczneValue;
    [SerializeField]
    private GameObject RedukcjaOgnisteValue;
    [SerializeField]
    private GameObject RedukcjaBlyskValue;
    [SerializeField]
    private GameObject RedukcjaStabilnoscValue;

    private void SetRedukcjaFizyczneValue(float value)
    {
        RedukcjaFizyczneValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    private void SetRedukcjaMagiczneValue(float value)
    {
        RedukcjaMagiczneValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    private void SetRedukcjaOgnisteValue(float value)
    {
        RedukcjaOgnisteValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    private void SetRedukcjaBlyskValue(float value)
    {
        RedukcjaBlyskValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    private void SetRedukcjaStabilnoscValue(int value)
    {
        RedukcjaStabilnoscValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    
    [Space(10)]
    [Header("Redukcja porownania")]
    [Space(10)]
    [SerializeField]
    private GameObject ComparRedukcjaFizyczne;
    [SerializeField]
    private GameObject ComparRedukcjaMagiczne;
    [SerializeField]
    private GameObject ComparRedukcjaOgniste;
    [SerializeField]
    private GameObject ComparRedukcjaBlysk;
    [SerializeField]
    private GameObject ComparRedukcjaStabilnosc;
    
    private void SetComparRedukcjaFizyczne(float comparedValue)
    {
        if (comparedValue > 0)
        {
            ComparRedukcjaFizyczne.SetActive(true);
            ComparRedukcjaFizyczne.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=#00ffffff>+" + comparedValue.ToString() + "</color>" + ")";
        }
        else if(comparedValue < 0)
        {
            ComparRedukcjaFizyczne.SetActive(true);
            ComparRedukcjaFizyczne.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=red>" + comparedValue.ToString() + "</color>" + ")";
        }
        else
        {
            ComparRedukcjaFizyczne.SetActive(false);
        }
    }
    
    private void SetComparRedukcjaMagiczne(float comparedValue)
    {
        if (comparedValue > 0)
        {
            ComparRedukcjaMagiczne.SetActive(true);
            ComparRedukcjaMagiczne.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=#00ffffff>+" + comparedValue.ToString() + "</color>" + ")";
        }
        else if(comparedValue < 0)
        {
            ComparRedukcjaMagiczne.SetActive(true);
            ComparRedukcjaMagiczne.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=red>" + comparedValue.ToString() + "</color>" + ")";
        }
        else
        {
            ComparRedukcjaMagiczne.SetActive(false);
        }
    }
    
    private void SetComparRedukcjaOgniste(float comparedValue)
    {
        if (comparedValue > 0)
        {
            ComparRedukcjaOgniste.SetActive(true);
            ComparRedukcjaOgniste.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=#00ffffff>+" + comparedValue.ToString() + "</color>" + ")";
        }
        else if(comparedValue < 0)
        {
            ComparRedukcjaOgniste.SetActive(true);
            ComparRedukcjaOgniste.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=red>" + comparedValue.ToString() + "</color>" + ")";
        }
        else
        {
            ComparRedukcjaOgniste.SetActive(false);
        }
    }
    
    private void SetComparRedukcjaBlysk(float comparedValue)
    {
        if (comparedValue > 0)
        {
            ComparRedukcjaBlysk.SetActive(true);
            ComparRedukcjaBlysk.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=#00ffffff>+" + comparedValue.ToString() + "</color>" + ")";
        }
        else if(comparedValue < 0)
        {
            ComparRedukcjaBlysk.SetActive(true);
            ComparRedukcjaBlysk.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=red>" + comparedValue.ToString() + "</color>" + ")";
        }
        else
        {
            ComparRedukcjaBlysk.SetActive(false);
        }
    }
    
    private void SetComparRedukcjaStabilnosc(int comparedValue)
    {
        if (comparedValue > 0)
        {
            ComparRedukcjaStabilnosc.SetActive(true);
            ComparRedukcjaStabilnosc.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=#00ffffff>+" + comparedValue.ToString() + "</color>" + ")";
        }
        else if(comparedValue < 0)
        {
            ComparRedukcjaStabilnosc.SetActive(true);
            ComparRedukcjaStabilnosc.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=red>" + comparedValue.ToString() + "</color>" + ")";
        }
        else
        {
            ComparRedukcjaStabilnosc.SetActive(false);
        }
    }
    
    
    
    #endregion redukcja
    
    #region wymagania
    
    [Space(10)]
    [Header("Wymagania")]
    [Space(10)]
    [SerializeField]
    private GameObject WymagSilaValue;
    [SerializeField]
    private GameObject WymagZrecznoscValue;
    [SerializeField]
    private GameObject WymagInteligencjaValue;
    [SerializeField]
    private GameObject WymagWiaraValue;
    [SerializeField]
    private GameObject WymagWytrzymValue;
    [SerializeField]
    private GameObject WymagUdzwigValue;
    
    private void SetWymagSilaValue(int value)
    {
        WymagSilaValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    private void SetWymagZrecznoscValue(int value)
    {
        WymagZrecznoscValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    private void SetWymagInteligencjaValue(int value)
    {
        WymagInteligencjaValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    private void SetWymagWiaraValue(int value)
    {
        WymagWiaraValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    private void SetWymagWytrzymValue(int value)
    {
        WymagWytrzymValue.GetComponent<TextMeshProUGUI>().text = value.ToString() + "/" + value;
    }
    private void SetWymagUdzwigValue(float value)
    {
        WymagUdzwigValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    
    [Space(10)]
    [Header("Wymagania porownanie")]
    [Space(10)]
    [SerializeField]
    private GameObject ComparWymagUdzwig;
    
    private void SetComparWymagUdzwig(float comparedValue)
    {
        if (comparedValue > 0)
        {
            ComparWymagUdzwig.SetActive(true);
            ComparWymagUdzwig.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=red>+" + comparedValue.ToString() + "</color>" + ")";
        }
        else if(comparedValue < 0)
        {
            ComparWymagUdzwig.SetActive(true);
            ComparWymagUdzwig.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=#00ffffff>" + comparedValue.ToString() + "</color>" + ")";
        }
        else
        {
            ComparWymagUdzwig.SetActive(false);
        }
    }
    
    #endregion wymagania
}
