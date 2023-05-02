using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private WeaponData _data;
    [SerializeField] public GameObject _weaponObject;
    private void Awake()
    {
        Debug.Log( _data.name + " equipped.");

    }

    private void Update()
    {
        Vector3 _weaponPos = _weaponObject.transform.position;
        //fire weapon
        if (_data._weaponType == 0)
        {

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Vector3 rayStartPos = _weaponObject.transform.position;
                Vector3 rayDirection = _weaponObject.transform.forward;
                Debug.DrawRay(rayStartPos, rayDirection * _data._shootDistance,
                    Color.cyan, 1);
                if (_data._fireSFX != null)
                {
                    AudioSource newSound = Instantiate(_data._fireSFX, _weaponPos, Quaternion.identity);
                    Destroy(newSound.gameObject, newSound.clip.length);
                }
            }

            //reload
            if (Input.GetKeyDown(KeyCode.R))
            {
                if (_data._reloadSFX != null)
                {
                    AudioSource newSound = Instantiate(_data._reloadSFX, _weaponPos, Quaternion.identity);
                    Destroy(newSound.gameObject, newSound.clip.length);
                }
            }
        }
    }



}
