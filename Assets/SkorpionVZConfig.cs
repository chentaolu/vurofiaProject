using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkorpionVZConfig : WeaponConfig {
    public void Start()
    {
        attackValue = 70;
        usingNow = false;
    }

    public void Update()
    {
        isWeaponCanUse = BuySkorpion_VZ.hasBeenBuy;
    }
}
