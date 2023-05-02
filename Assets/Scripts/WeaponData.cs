using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "WeaponData_", menuName = "ItemData/Weapon")]
public class WeaponData : ScriptableObject
{
    [Header("Weapon Info")]
    [SerializeField] public string _name = "...";

    [Header("Combat Stats")]
    [SerializeField] public WeaponType _weaponType;
    [SerializeField] public float _damangeAmount = 1;
    [SerializeField][Tooltip("If weapon is melee, leave blank")] public float _shootDistance = 20;
    [SerializeField][Tooltip("If weapon is melee, leave blank")] public int _maxAmmo = 12;
    [SerializeField][Tooltip("If weapon is melee, leave blank")] public int _magSize = 3;
    [SerializeField][Tooltip("Can you look down sights?")] public bool _LDS;
    [Header("SFX")]
    [SerializeField] public AudioSource _fireSFX;
    [SerializeField] public AudioSource _reloadSFX;

}
