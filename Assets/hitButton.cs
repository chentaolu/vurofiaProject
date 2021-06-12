using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitButton : MonoBehaviour {
    public Enemy enemy;
    public void OnBtn()
    {
        enemy.beHit = true;
        enemy.nowBlood = enemy.nowBlood - 25;
    }
}
