using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Enemy : MonoBehaviour {
    public Animator animator;
    public PlayerScript player;
    public int Armor;
    public float nowBlood;
    public float maxBlood;
    public float precentBlood;
    public health health;
    public bool beHit;
    public float timer = 0;
    public float temp;
    public float attackValue = 10;
    public bool eventCheck = true;

	// Use this for initialization
	void Start () {
        this.maxBlood = 100 * Level.nowLevel;
        this.nowBlood = this.maxBlood;
        this.precentBlood = this.maxBlood / this.maxBlood * 100;
        health.maxHealth = this.precentBlood;
        this.Armor = 10 * Level.nowLevel;
        this.animator = GetComponent<Animator>();
        this.beHit = false;
    }
	
	// Update is called once per frame
	void Update () {
        attackValue = (float)(10 * (((float)Level.nowLevel * 0.25) + 1));
        this.timer += Time.deltaTime;
        float second = this.timer % 60 + 1;
        float temp = second % attackSecond();
        string t = temp.ToString("0.0");
        
        if (t == "0.0" && this.eventCheck == true)
        {
            if(temp < 0.0165 + (float)Level.nowLevel * 0.0003){
                this.animator.SetBool("attackOrNot", true);
                Player_health.currentHealth -= attackValue;
            }              
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
            Level.nextLevel();
            updateToNextLevel();
            this.timer = 0;
            player.playerInToNextLevel();
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

    public void updateToNextLevel()
    {
        this.maxBlood = 100 * Level.nowLevel;
        this.nowBlood = this.maxBlood;
        precentBlood = this.nowBlood / this.nowBlood * 100;
        health.maxHealth = precentBlood;
        health.Hurt.sizeDelta = new Vector2(this.maxBlood / this.maxBlood * 100, health.Hurt.sizeDelta.y);
    }

    public Animator GetAnimator()
    {
        return this.animator;
    }

    public float attackSecond()
    {
        float attackSec = 10 - (Level.nowLevel * 2);
        if (attackSec <= 2)
        {
            attackSec = 2;
        }
        return attackSec;
    }
}
