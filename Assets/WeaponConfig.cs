using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponConfig : MonoBehaviour {
    public bool usingNow;
    public int attackValue;

    public int getValue()
    {
        return attackValue;
    }

    public abstract bool getBoolCanUseOrNot();
}
