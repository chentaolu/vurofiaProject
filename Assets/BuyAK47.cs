using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyAK47 : MonoBehaviour {
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
            if (ScoreBoard.Score < 1000)
            {

            }
            else
            {
                ScoreBoard.Score -= 1000;
                GameObject.Find("BuyAK47").GetComponent<Button>().transform.Find("Text").GetComponent<Text>().text = "Sold Out!";
                hasBeenBuy = true;
            }
        }
        else
        {
            GameObject.Find("BuyAK47").GetComponent<Button>().transform.Find("Text").GetComponent<Text>().text = "Sold Out!";
        }
    }
}
