using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeConfig : WeaponConfig {
 
    public void Start()
    {
        attackValue = 20;
        isWeaponCanUse = true;
        usingNow = true;
    }
}
