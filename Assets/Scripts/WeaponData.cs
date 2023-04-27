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
    [SerializeField] string _name = "...";

    [Header("Combat Stats")]
    [SerializeField] WeaponType _weaponType;
    [SerializeField] float _damangeAmount = 1;
    [SerializeField][Tooltip("If weapon is melee, leave blank")] int _maxAmmo = 12;
    [SerializeField][Tooltip("If weapon is melee, leave blank")] int _magSize = 3;
    [SerializeField][Tooltip("Can you look down sights?")] bool _LDS;

    [Header("SFX")]
    [SerializeField] AudioClip _fireSFX;
    [SerializeField] AudioClip _reloadSFX;
    [SerializeField] ParticleSystem _fireVFX;

}
