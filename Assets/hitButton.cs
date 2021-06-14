using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class hitButton : MonoBehaviour {
    public Enemy enemy;
    public health health;
    public bool pressButton = false;
    public PlayerScript player;

    public void Update()
    {
        pressButton = false;
    }

    public void OnBtn()
    {
        enemy.beHit = true;
        pressButton = true;
        enemy.nowBlood = enemy.nowBlood - player.weaponAttackValue;
        
        enemy.precentBlood = enemy.precentBlood - ((player.weaponAttackValue / enemy.maxBlood) * 100);
    }

}
