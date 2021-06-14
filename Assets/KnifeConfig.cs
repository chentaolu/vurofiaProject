using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeConfig : WeaponConfig {
    public static bool isWeaponCanUse;
    
    public void Start()
    {
        x = -0.0169727;
        y = 0.01034474;
        z = -0.0118871;
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
