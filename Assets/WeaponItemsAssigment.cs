using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WeaponItemsAssigment : MonoBehaviour, CategoryItemsAssigment
{
    [SerializeField] private TextMeshProUGUI _attack;
    [SerializeField] private TextMeshProUGUI _bolt;
    [SerializeField] private TextMeshProUGUI _durability;
    [SerializeField] private TextMeshProUGUI _fire;
    [SerializeField] private TextMeshProUGUI _magic;
    [SerializeField] private TextMeshProUGUI _weight;
    public void AssignItem(Item item)
    {
        WeaponItem weaponItem = (WeaponItem) item;
        _attack.text = weaponItem.Attack.ToString();
        _bolt.text = weaponItem.Bolt.ToString();
        _durability.text = weaponItem.Durability.ToString();
        _fire.text = weaponItem.Fire.ToString();
        _magic.text = weaponItem.Magic.ToString();
        _weight.text = weaponItem.Weight.ToString();
    }
}
