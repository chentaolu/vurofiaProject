using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeConfig : WeaponConfig {

    private int attackValue = 20;

    public void Start()
    {
        isWeaponCanUse = true;
    }

    public int getValue()
    {
        return this.attackValue;
    }
}
