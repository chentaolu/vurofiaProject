using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UMP45Config : WeaponConfig {
    public void Start()
    {
        attackValue = 30;
        usingNow = false;
    }

    public void Update()
    {
        isWeaponCanUse = BuyUMP_45.hasBeenBuy;
    }
}
