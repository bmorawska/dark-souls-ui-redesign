using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WeightBarController : MonoBehaviour
{
    [SerializeField] private RectTransform _barFill;
    [SerializeField] private RectTransform _arrow;
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
        if (weight > MaxWeight)
            weight = MaxWeight;
        _barFill.localScale = new Vector3(weight/MaxWeight, 1,1);
        var arrowPosition = _arrow.anchoredPosition;
        arrowPosition.x = _barFill.sizeDelta.x * (weight / MaxWeight);
        _arrow.anchoredPosition = arrowPosition;
    }
}
