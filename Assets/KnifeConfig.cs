using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeConfig : WeaponConfig {
    public static bool isWeaponCanUse;
    
    public void Start()
    {
        attackValue = 20;
        isWeaponCanUse = true;
        usingNow = true;
    }
    public override bool getBoolCanUseOrNot()
    {
        bool result = isWeaponCanUse;
        return result;
    }
}
