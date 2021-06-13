using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkorpionVZConfig : WeaponConfig {

    private int attackValue = 70;
    public void Update()
    {
        isWeaponCanUse = BuySkorpion_VZ.hasBeenBuy;
    }

    public int getValue()
    {
        return this.attackValue;
    }
}
