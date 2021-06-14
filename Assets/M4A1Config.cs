using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M4A1Config : WeaponConfig {

    public static bool isWeaponCanUse = false;
    public void Start()
    {
        attackValue = 100;
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
