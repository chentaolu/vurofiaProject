using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ak_47Config : WeaponConfig
{
    public static bool isWeaponCanUse = false;
    public void Start()
    {
        attackValue = 125;
        usingNow = false;
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
