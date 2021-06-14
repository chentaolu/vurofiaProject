using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkorpionVZConfig : WeaponConfig {
    public static bool isWeaponCanUse = false;
    public void Start()
    {
        x = 0.001132019;
        y = 0.001109898;
        z = -0.001778394;
        attackValue = 70;
        usingNow = false;
        GoOutOfRange();
        print(attackValue);
    }

    public void Update()
    {
        
    }

    public override bool getBoolCanUseOrNot()
    {
        bool result = isWeaponCanUse;
        return result;
    }
}
