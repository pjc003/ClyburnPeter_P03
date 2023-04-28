using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] GameObject _weapon1;
    [SerializeField] GameObject _weapon2;
    [SerializeField] GameObject _weapon3;
    [SerializeField] GameObject _weapon4;
    [SerializeField] GameObject _weapon5;
    [SerializeField] GameObject _weapon6;
    [SerializeField] GameObject _weapon7;
    [SerializeField] GameObject _weapon8;
    [SerializeField] GameObject _weapon9;
    [SerializeField] GameObject _weapon10;

    public enum Slot
    {
        picker, w1, w2, w3, w4, w5, w6, w7, w8, w9, w10
    }

    public Slot currentSlot = Slot.picker;

    private void Update()
    {

        switch (currentSlot)
        {
            case Slot.picker:
                Picker();
                break;
            case Slot.w1:
                Slot1();
                break;
            case Slot.w2:
                Slot2();
                break;
            /*case Slot.w3:
                Slot3();
                break;
            case Slot.w4:
                Slot4();
                break;*/
        }

    }

    public void Picker()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangeSlot(Slot.w1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeSlot(Slot.w2);
        }

    }

    public void Slot1()
    {

        if (_weapon1 != null)
        {
            if (!_weapon1.activeSelf)
            {
                _weapon1.SetActive(true);
                Debug.Log("weapon 1 equipped");
                ChangeSlot(Slot.picker);
            }

            else
            {
                _weapon1.SetActive(false);
                Debug.Log("weapon 1 unequipped");
                ChangeSlot(Slot.picker);
            }
        }

    }

    public void Slot2()
    {

        if (_weapon2 != null)
        {
            if (!_weapon2.activeSelf)
            {
                _weapon2.SetActive(true);
                Debug.Log("weapon 2 equipped");
                ChangeSlot(Slot.picker);
            }

            else
            {
                _weapon2.SetActive(false);
                Debug.Log("weapon 2 unequipped");
                ChangeSlot(Slot.picker);
            }
        }

    }

    public void ChangeSlot(Slot newSlot)
    {
        if (currentSlot == newSlot)
            return;

        currentSlot = newSlot;
    }
}
