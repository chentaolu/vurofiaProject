﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitButton : MonoBehaviour {
    public Enemy enemy;

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnMouseDown()
    {
        enemy.nowBlood = enemy.nowBlood - 100;
    }
}
