using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class hitButton : MonoBehaviour {
    public Enemy enemy;
    public health health;
    public bool pressButton = false;

    public void Update()
    {
        pressButton = false;
    }

    public void OnBtn()
    {
        enemy.beHit = true;
        pressButton = true;
        enemy.nowBlood = enemy.nowBlood - 25;
        enemy.precentBlood = enemy.precentBlood - ((25 / enemy.maxBlood) * 100);
    }

}
