using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class levelBoard : MonoBehaviour {
	public Text showLevel;
	public int enemyLevel;

	// Use this for initialization
	void Start () {
		this.enemyLevel = Level.nowLevel;
	}
	
	// Update is called once per frame
	void Update () {
		this.enemyLevel = Level.nowLevel;
		showLevel.text = enemyLevel.ToString();
	}
}
