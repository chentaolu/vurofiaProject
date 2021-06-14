using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonConfig : WeaponConfig
{

    public static bool isWeaponCanUse = false;
    void Start()
    {
        x = -0.0047389;
        y = -0.061491;
        z = 0.017445;
        attackValue = 10000;
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
