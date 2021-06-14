using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyUMP_45 : MonoBehaviour {
    public static bool hasBeenBuy = false;

	// Use this for initialization
	void Start () {
		if(hasBeenBuy)
        {
            GameObject.Find("BuyUMP45").GetComponent<Button>().transform.Find("Text").GetComponent<Text>().text = "Sold Out!";
        }
	}
	
	// Update is called once per frame
	void Update () {
        UMP45Config.isWeaponCanUse = hasBeenBuy;
	}

    public void OnBtn()
    {
        if (!hasBeenBuy)
        {
            if (ScoreBoard.Score < 100)
            {
                GameObject.Find("BuyUMP45").GetComponent<Button>().transform.Find("Text").GetComponent<Text>().text = "100你也要搶乞丐";
            }
            else
            {
                ScoreBoard.Score -= 100;
                GameObject.Find("BuyUMP45").GetComponent<Button>().transform.Find("Text").GetComponent<Text>().text = "Sold Out!";
                hasBeenBuy = true;
                
            }
        }
        else
        {
            GameObject.Find("BuyUMP45").GetComponent<Button>().transform.Find("Text").GetComponent<Text>().text = "Sold Out!";
        }
    }
}
