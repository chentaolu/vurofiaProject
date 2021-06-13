using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M4A1Config : WeaponConfig {

    private int attackValue = 100;

    public void Update()
    {
        isWeaponCanUse = BuyM4A1.hasBeenBuy;
    }

    public int getValue()
    {
        return this.attackValue;
    }
}
