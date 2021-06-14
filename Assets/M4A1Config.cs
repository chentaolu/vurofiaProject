using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M4A1Config : WeaponConfig {

    public static bool isWeaponCanUse = false;
    void Start()
    {
        x = -0.0047389;
        y = -0.061491;
        z = 0.17445;
        attackValue = 100;
        usingNow = false;
        GoOutOfRange();
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
