﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class restartBtn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnBtn() {
        Level.nowLevel = 1;
        Player_health.currentHealth = 100;
        ScoreBoard.Score = 0;
        SceneManager.LoadScene(0);
        Ak_47Config.isWeaponCanUse = false;
        M4A1Config.isWeaponCanUse = false;
        SkorpionVZConfig.isWeaponCanUse = false;
        UMP45Config.isWeaponCanUse = false;
    }
}
