using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyUMP_45 : MonoBehaviour {
    public static bool hasBeenBuy = false;

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
            if (ScoreBoard.Score < 100)
            {

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
