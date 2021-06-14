using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponConfig : MonoBehaviour {
    public static bool isWeaponCanUse;
    public bool usingNow;
    public int attackValue;

    public int getValue()
    {
        return this.attackValue;
    }

    public bool getBoolCanUseOrNot()
    {
        bool result = isWeaponCanUse;
        return result;
    }
}
