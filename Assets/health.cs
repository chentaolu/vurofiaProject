using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour {
	public float maxHealth;

    public float currentHealth;
	public float percentHealth;
	public RectTransform HealthBar,Hurt;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        //將綠色血條同步到當前血量長度

        HealthBar.sizeDelta = new Vector2(currentHealth, HealthBar.sizeDelta.y);

        //呈現傷害量
        if (Hurt.sizeDelta.x > HealthBar.sizeDelta.x)

        {

            //讓傷害量(紅色血條)逐漸追上當前血量

            Hurt.sizeDelta += new Vector2(-1, 0)*Time.deltaTime*10;

        }

    }
	
}
