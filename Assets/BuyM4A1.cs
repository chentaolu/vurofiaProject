using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyM4A1 : MonoBehaviour {
    static bool hasBeenBuy = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnBtn()
    {
        if (!hasBeenBuy)
        {
            if (ScoreBoard.Score < 200)
            {

            }
            else
            {
                ScoreBoard.Score -= 400;
                GameObject.Find("BuyM4A1").GetComponent<Button>().transform.Find("Text").GetComponent<Text>().text = "Sold Out!";
                hasBeenBuy = true;
            }
        }
        else
        {
            GameObject.Find("BuyM4A1").GetComponent<Button>().transform.Find("Text").GetComponent<Text>().text = "Sold Out!";
        }
    }
}
