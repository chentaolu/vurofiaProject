using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_health : MonoBehaviour {
	public float maxHealth;
	public float currentHealth;
	public float precentHealth;
	public RectTransform HealthBar,Hurt;
	// Use this for initialization
	void Start () {
		this.maxHealth = 100;
		this.currentHealth = this.maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
		 HealthBar.sizeDelta = new Vector2(currentHealth, HealthBar.sizeDelta.y);

        //呈現傷害量

        if (Hurt.sizeDelta.x > HealthBar.sizeDelta.x)

        {

            //讓傷害量(紅色血條)逐漸追上當前血量

            Hurt.sizeDelta += new Vector2(-1, 0)*Time.deltaTime*10;

        }
	}
}
