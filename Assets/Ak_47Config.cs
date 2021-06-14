using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ak_47Config : WeaponConfig
{
    public void Start()
    {
        attackValue = 125;
        usingNow = false;
    }

    public void Update()
    {
        isWeaponCanUse = BuyAK47.hasBeenBuy;
    }
}
