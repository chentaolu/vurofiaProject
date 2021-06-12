using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitButton : MonoBehaviour {
    public Enemy enemy;

    public void OnBtn()
    {
        enemy.GetAnimator().SetBool("hitOrNot", true);
        enemy.nowBlood = enemy.nowBlood - 50;
    }
}
