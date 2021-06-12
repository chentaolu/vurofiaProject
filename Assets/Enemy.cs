using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Enemy : MonoBehaviour {
    private Animator animator;
    public Level level;
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
            Debug.Log("he is dead!!");
            level.nextLevel();
            updateBlood();
            Debug.Log("init to false");
            this.animator.SetBool("deadOrNot", false);
            this.animator.SetBool("hitOrNot", false);
        }
        else
        {

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
