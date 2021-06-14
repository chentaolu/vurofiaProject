using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M4A1Config : WeaponConfig {
    public void Start()
    {
        attackValue = 100;
        usingNow = false;
    }

    public void Update()
    {
        isWeaponCanUse = BuyM4A1.hasBeenBuy;
    }
}
