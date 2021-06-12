using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Enemy : MonoBehaviour {
    public Animator animator;
    public Level level;
    public int Armor;
    public int nowBlood;
    public health health;
    public bool beHit;

	// Use this for initialization
	void Start () {
        this.nowBlood = 100 * level.nowLevel;
        this.Armor = 10 * level.nowLevel;
        this.animator = GetComponent<Animator>();
        this.beHit = false;
    }
	
	// Update is called once per frame
	void Update () {
        if(this.beHit)
        {
            this.animator.SetBool("hitOrNot", beHit);
            this.beHit = false;
        }
        else
        {
            this.animator.SetBool("hitOrNot", beHit);
        }
        
		if(this.isDead())
        {
            level.nextLevel();
            updateBlood();
        }
        else
        {
            this.animator.SetBool("deadOrNot", false);
        }
	}

    public bool isDead()
    {
        if (nowBlood <= 0)
        {
            this.animator.SetBool("deadOrNot", true);
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

    public Animator GetAnimator()
    {
        return this.animator;
    }

}
