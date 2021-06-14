using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyMedicineCabinet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void OnBtn()
    {
        if (ScoreBoard.Score < 300)
        {
            GameObject.Find("BuySkorpion_VZ").GetComponent<Button>().transform.Find("Text").GetComponent<Text>().text = "老闆不做慈善事業";
        }
        else
        {
            ScoreBoard.Score -= 300;
            MedicineCabinetScript.amount += 1;
        }
    }
}
