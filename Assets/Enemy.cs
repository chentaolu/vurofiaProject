using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Enemy : MonoBehaviour {
    public Animator animator;
    public Level level;
    public int Armor;
    public float nowBlood;
    public float maxBlood;
    public float precentBlood;
    public health health;
    public bool beHit;
    public float timer = 0;

	// Use this for initialization
	void Start () {
        this.maxBlood = 100 * level.nowLevel;
        this.nowBlood = this.maxBlood;
        this.precentBlood = this.maxBlood / this.maxBlood * 100;
        health.maxHealth = this.precentBlood;
        this.Armor = 10 * level.nowLevel;
        this.animator = GetComponent<Animator>();
        this.beHit = false;
    }
	
	// Update is called once per frame
	void Update () {

        this.timer += Time.deltaTime;
        int second = (int)this.timer % 60 + 1;
        if (second % attackSecond() == 0)
        {
            this.animator.SetBool("attackOrNot", false);
        }
        else
        {
            this.animator.SetBool("attackOrNot", false);
        }

        health.currentHealth  = precentBlood;
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
        this.maxBlood = 100 * level.nowLevel;
        this.nowBlood = this.maxBlood;
        precentBlood = this.nowBlood / this.nowBlood * 100;
        health.maxHealth = precentBlood;
        health.Hurt.sizeDelta = new Vector2(this.maxBlood / this.maxBlood * 100, health.Hurt.sizeDelta.y);
    }

    public Animator GetAnimator()
    {
        return this.animator;
    }

    public int attackSecond()
    {
        int attackSec = 10 - (this.level.nowLevel * 2);
        if (attackSec <= 2)
        {
            attackSec = 2;
        }
        return attackSec;
    }
}
