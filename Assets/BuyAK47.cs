using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyAK47 : MonoBehaviour {
    public static bool hasBeenBuy = false;

    // Use this for initialization
    void Start () {
        if (hasBeenBuy)
        {
            GameObject.Find("BuyAK47").GetComponent<Button>().transform.Find("Text").GetComponent<Text>().text = "Sold Out!";
        }
	}
	
	// Update is called once per frame
	void Update () {
        Ak_47Config.isWeaponCanUse = hasBeenBuy;
	}

    public void OnBtn()
    {
        if (!hasBeenBuy)
        {
            if (ScoreBoard.Score < 1000)
            {
                GameObject.Find("BuyAK47").GetComponent<Button>().transform.Find("Text").GetComponent<Text>().text = "你騙不到老闆";
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
