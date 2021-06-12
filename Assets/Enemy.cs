using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    private Animator animator;
    public Level level = new Level();
    public int Armor;
    public int nowBlood;
	// Use this for initialization
	void Start () {
        this.nowBlood = 100 * level.nowLevel;
        this.Armor = 10 * level.nowLevel;
        this.animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		if(this.isDead())
        {
            level.nextLevel();
            updateBlood();
        }
        else
        {

        }
	}

    public bool isDead()
    {
        if (nowBlood <= 0)
        {
            this.animator.SetBool("deadOrNoot", true);
            return true;
        } else
        {
            return false;
        }
    }

    public void updateBlood()
    {
        this.nowBlood = 100 * level.nowLevel;
    }

}
