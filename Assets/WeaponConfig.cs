using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponConfig : MonoBehaviour {
    public bool usingNow;
    public int attackValue;
    public double x, y, z;

    public int getValue()
    {
        return attackValue;
    }

    public abstract bool getBoolCanUseOrNot();

    public void GoToRightLocation()
    {
        gameObject.transform.localPosition = Vector3.MoveTowards(gameObject.transform.localPosition, new Vector3((float)x, (float)y, (float)z), 1);
    }

    public void GoOutOfRange()
    {
        gameObject.transform.localPosition = Vector3.MoveTowards(gameObject.transform.localPosition, new Vector3(3000, 3000, 3000), 1);
    }
}
