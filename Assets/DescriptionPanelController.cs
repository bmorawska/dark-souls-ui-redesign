using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DescriptionPanelController : MonoBehaviour
{
    [SerializeField]
    private GameObject WeaponName;
    [SerializeField]
    private GameObject AttackType;
    [SerializeField]
    private GameObject WeaponType;

    public void SetWeaponName(string name)
    {
        WeaponName.GetComponent<TextMeshProUGUI>().text = name;
    }
    public void SetAttackType(string type)
    {
        AttackType.GetComponent<TextMeshProUGUI>().text = "Rodzaj ataku: <u>" + type + "</u>";
    }
    public void SetWeaponType(string type)
    {
        WeaponType.GetComponent<TextMeshProUGUI>().text = "Rodzaj broni: <u>" + type + "</u>";
    }

    #region atakObrazenia
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

    public void SetObrazeniaFizyczneValue(int value)
    {
        ObrazeniaFizyczneValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    public void SetObrazeniaMagiczneValue(int value)
    {
        ObrazeniaMagiczneValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    public void SetObrazeniaOgnisteValue(int value)
    {
        ObrazeniaOgnisteValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    public void SetObrazeniaBlyskValue(int value)
    {
        ObrazeniaBlyskValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    public void SetObrazeniaKrytyczneValue(int value)
    {
        ObrazeniaKrytyczneValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    
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

    public void SetComparAtakFizyczne(int comparedValue)
    {
        if (comparedValue > 0)
        {
            ComparAtakFizyczne.SetActive(true);
            ComparAtakFizyczne.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=cyan>+" + comparedValue.ToString() + "</color>" + ")";
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
    
    public void SetComparAtakMagiczne(int comparedValue)
    {
        if (comparedValue > 0)
        {
            ComparAtakMagiczne.SetActive(true);
            ComparAtakMagiczne.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=cyan>+" + comparedValue.ToString() + "</color>" + ")";
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
    
    public void SetComparAtakOgniste(int comparedValue)
    {
        if (comparedValue > 0)
        {
            ComparAtakOgniste.SetActive(true);
            ComparAtakOgniste.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=cyan>+" + comparedValue.ToString() + "</color>" + ")";
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
    
    public void SetComparAtakBlysk(int comparedValue)
    {
        if (comparedValue > 0)
        {
            ComparAtakBlysk.SetActive(true);
            ComparAtakBlysk.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=cyan>+" + comparedValue.ToString() + "</color>" + ")";
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
    
    public void SetComparAtakKrytyczne(int comparedValue)
    {
        if (comparedValue > 0)
        {
            ComparAtakKrytyczne.SetActive(true);
            ComparAtakKrytyczne.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=cyan>+" + comparedValue.ToString() + "</color>" + ")";
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
    
    #endregion atakObrazenia

    #region redukcja
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

    public void SetRedukcjaFizyczneValue(float value)
    {
        RedukcjaFizyczneValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    public void SetRedukcjaMagiczneValue(float value)
    {
        RedukcjaMagiczneValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    public void SetRedukcjaOgnisteValue(float value)
    {
        RedukcjaOgnisteValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    public void SetRedukcjaBlyskValue(float value)
    {
        RedukcjaBlyskValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    public void SetRedukcjaStabilnoscValue(int value)
    {
        RedukcjaStabilnoscValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    
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
    
    public void SetComparRedukcjaFizyczne(float comparedValue)
    {
        if (comparedValue > 0)
        {
            ComparRedukcjaFizyczne.SetActive(true);
            ComparRedukcjaFizyczne.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=cyan>+" + comparedValue.ToString() + "</color>" + ")";
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
    
    public void SetComparRedukcjaMagiczne(float comparedValue)
    {
        if (comparedValue > 0)
        {
            ComparRedukcjaMagiczne.SetActive(true);
            ComparRedukcjaMagiczne.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=cyan>+" + comparedValue.ToString() + "</color>" + ")";
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
    
    public void SetComparRedukcjaOgniste(float comparedValue)
    {
        if (comparedValue > 0)
        {
            ComparRedukcjaOgniste.SetActive(true);
            ComparRedukcjaOgniste.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=cyan>+" + comparedValue.ToString() + "</color>" + ")";
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
    
    public void SetComparRedukcjaBlysk(float comparedValue)
    {
        if (comparedValue > 0)
        {
            ComparRedukcjaBlysk.SetActive(true);
            ComparRedukcjaBlysk.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=cyan>+" + comparedValue.ToString() + "</color>" + ")";
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
    
    public void SetComparRedukcjaStabilnosc(int comparedValue)
    {
        if (comparedValue > 0)
        {
            ComparRedukcjaStabilnosc.SetActive(true);
            ComparRedukcjaStabilnosc.GetComponent<TextMeshProUGUI>().text =
                "(" + "<color=cyan>+" + comparedValue.ToString() + "</color>" + ")";
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
    
    public void SetWymagSilaValue(int value)
    {
        WymagSilaValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    public void SetWymagZrecznoscValue(int value)
    {
        WymagZrecznoscValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    public void SetWymagInteligencjaValue(int value)
    {
        WymagInteligencjaValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    public void SetWymagWiaraValue(int value)
    {
        WymagWiaraValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    public void SetWymagWytrzymValue(int value)
    {
        WymagWytrzymValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    public void SetWymagUdzwigValue(int value)
    {
        WymagUdzwigValue.GetComponent<TextMeshProUGUI>().text = value.ToString();
    }
    
    [SerializeField]
    private GameObject ComparWymagUdzwig;
    
    public void SetComparWymagUdzwig(int comparedValue)
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
                "(" + "<color=cyan>" + comparedValue.ToString() + "</color>" + ")";
        }
        else
        {
            ComparWymagUdzwig.SetActive(false);
        }
    }
    
    #endregion wymagania
}
