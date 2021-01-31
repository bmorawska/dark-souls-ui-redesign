using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ArmorItemsAssigment : MonoBehaviour, CategoryItemsAssigment
{
    [SerializeField] private TextMeshProUGUI _attack;
    [SerializeField] private TextMeshProUGUI _bolt;
    [SerializeField] private TextMeshProUGUI _durability;
    [SerializeField] private TextMeshProUGUI _fire;
    [SerializeField] private TextMeshProUGUI _magic;
    [SerializeField] private TextMeshProUGUI _weight;
    public void AssignItem(Item item)
    {
        ArmorItem weaponItem = (ArmorItem) item;
        _attack.text = weaponItem.AttackDefence.ToString();
        _bolt.text = weaponItem.BoltDefence.ToString();
        _durability.text = weaponItem.DurabilityDefence.ToString();
        _fire.text = weaponItem.FireDefence.ToString();
        _magic.text = weaponItem.MagicDefence.ToString();
        _weight.text = weaponItem.Weight.ToString();
    }
}
