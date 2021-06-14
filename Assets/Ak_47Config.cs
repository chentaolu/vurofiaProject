using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ak_47Config : WeaponConfig
{
    public static bool isWeaponCanUse = false;
    public void Start()
    {
        x = -0.049;
        y = 0.4142412;
        z = 0.2382193;
        attackValue = 125;
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
