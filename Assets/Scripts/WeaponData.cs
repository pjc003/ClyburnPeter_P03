using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
    private LayerMask _layersToShoot = -1;
    [Header("Player camera")]
    [SerializeField] public Camera _camera;

    [Header("Weapon Info")]
    [SerializeField] string _name = "...";

    [Header("Combat Stats")]
    [SerializeField] WeaponType _weaponType;
    [SerializeField] float _damangeAmount = 1;
    [SerializeField][Tooltip("If weapon is melee, leave blank")] float _shootDistance = 20;
    [SerializeField][Tooltip("If weapon is melee, leave blank")] int _maxAmmo = 12;
    [SerializeField][Tooltip("If weapon is melee, leave blank")] int _magSize = 3;
    [SerializeField][Tooltip("Can you look down sights?")] bool _LDS;

    [Header("SFX")]
    [SerializeField] AudioSource _fireSFX;
    [SerializeField] AudioSource _reloadSFX;
    [SerializeField] ParticleSystem _fireVFX;


    public void OnPointerClick()
    {
        //ranged attack
        if (_weaponType == 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 rayStartPos = _camera.transform.position;
                Vector3 rayDirection = _camera.transform.forward;
                Debug.DrawRay(rayStartPos, rayDirection * _shootDistance,
                    Color.cyan, 1);
                RaycastHit hitInfo;
                if (Physics.Raycast(rayStartPos, rayDirection, out hitInfo,
                    _shootDistance, _layersToShoot))
                {
                    if (_fireVFX != null)
                    {
                        Instantiate(_fireVFX,
                            hitInfo.point, Quaternion.identity);
                    }

                    //TRANSFORM THROWS ERROR
                    /*if (_fireSFX != null)
                    {
                        AudioSource newSound = Instantiate(_fireSFX,
                            transform.position, Quaternion.identity);
                        Destroy(newSound.gameObject, newSound.clip.length);
                    }
                    
                    //NEED REPLACEMENT FOR SHOOTABLE
                    Shootable shootableObject = hitInfo.transform.GetComponent<Shootable>();
                    if (shootableObject != null)
                    {
                        shootableObject.Shoot();
                    }*/
                }
            }
        }
   

        //reload


        //melee attack
        if (_weaponType != 0)
        {

        }
 

   }   

}
