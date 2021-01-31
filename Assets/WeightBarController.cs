using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class WeightBarController : MonoBehaviour
{
    [SerializeField] private RectTransform _barFill;
    [SerializeField] private RectTransform _arrow;
    [SerializeField] private TextMeshProUGUI _value;
    [SerializeField] private TextMeshProUGUI _percent;
    public float MaxWeight = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void UpdateBar()
    {
        float weight = FindObjectsOfType<WearableController>()
            .Where(w => w.item != null)
            .Sum(w => w.item.Weight);
        _value.text = weight.ToString();
        if (weight > MaxWeight)
            weight = MaxWeight;
        float p = weight / MaxWeight;
        _barFill.localScale = new Vector3(p, 1,1);
        var arrowPosition = _arrow.anchoredPosition;
        arrowPosition.x = _barFill.sizeDelta.x * (p);
        _arrow.anchoredPosition = arrowPosition;
        _percent.text = (((int) (p * 1000)) / 10f).ToString() + "%";
    }
}
