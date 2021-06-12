using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public Level level = new Level();
    public int Armor;
    public int nowBlood;
	// Use this for initialization
	void Start () {
        this.nowBlood = 100 * level.nowLevel;
        this.Armor = 10 * level.nowLevel;

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
