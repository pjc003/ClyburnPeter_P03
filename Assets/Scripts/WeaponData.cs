using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponData_", menuName = "ItemData/Weapon")]
public class WeaponData : ScriptableObject
{
    //INCLUDE:
    /* name!
     * type
     * damage to deal!
     * max ammo!
     * LDS bool!
     * raycasting
     * sound effects!
     * vfx!
     * crosshair
     * gameobject
     * */
    [Header("Weapon Info")]
    [SerializeField] private string _name = "...";
    [Header("Combat Stats")]
    [SerializeField] private WeaponType _weaponType;
    [SerializeField] private float _damangeAmount = 1;
    [SerializeField][Tooltip("If weapon is melee, leave blank")] private int _maxAmmo = 12;
    [SerializeField][Tooltip("If weapon is melee, leave blank")] private int _magSize = 3;
    [SerializeField][Tooltip("Can you look down sights?")] private bool _LDS;
    [Header("SFX")]
    [SerializeField] private AudioClip _fireSFX;
    [SerializeField] private AudioClip _reloadSFX;
    [SerializeField] private ParticleSystem _fireVFX;

}
