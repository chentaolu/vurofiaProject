using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ak_47Config : WeaponConfig {
    private int attackValue = 125;
    
    public void Update()
    {
        isWeaponCanUse = BuyAK47.hasBeenBuy;
    }
    // Use this for initialization
    public int getValue()
    {
        return this.attackValue;
    }
}
