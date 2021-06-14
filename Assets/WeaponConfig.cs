using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponConfig : MonoBehaviour {
    public bool isWeaponCanUse;
    public bool usingNow;
    public int attackValue;

    public int getValue()
    {
        return this.attackValue;
    }
}
