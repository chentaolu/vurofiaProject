using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonConfig : WeaponConfig
{

    public static bool isWeaponCanUse = false;
    void Start()
    {
        x = -1.8727;
        y = 1.034474;
        z = -4.18871;
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
