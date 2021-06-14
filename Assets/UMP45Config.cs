using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UMP45Config : WeaponConfig {
    public static bool isWeaponCanUse = false;
    public void Start()
    {
        x = 0.01002;
        y = -0.0088333;
        z = -0.076355;
        attackValue = 30;
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
