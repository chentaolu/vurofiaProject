using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UMP45Config : WeaponConfig {

    private int attackValue = 30;

    public void Update()
    {
        isWeaponCanUse = BuyUMP_45.hasBeenBuy;
    }

    public int getValue()
    {
        return this.attackValue;
    }
}
