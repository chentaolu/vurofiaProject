using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MedicineCabinetTextScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        print(MedicineCabinetScript.amount);
        GetComponent<Text>().text = MedicineCabinetScript.amount.ToString();
	}
}
