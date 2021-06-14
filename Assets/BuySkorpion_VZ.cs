using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuySkorpion_VZ : MonoBehaviour {
    public static bool hasBeenBuy = false;
	// Use this for initialization
	void Start () {
        if (hasBeenBuy)
        {
            GameObject.Find("BuySkorpion_VZ").GetComponent<Button>().transform.Find("Text").GetComponent<Text>().text = "Sold Out!";
        }
    }
	
	// Update is called once per frame
	void Update () {
        SkorpionVZConfig.isWeaponCanUse = hasBeenBuy;
	}

    public void OnBtn()
    {
        if (!hasBeenBuy)
        {
            if (ScoreBoard.Score < 200)
            {
                GameObject.Find("BuySkorpion_VZ").GetComponent<Button>().transform.Find("Text").GetComponent<Text>().text = "200都沒有可憐";
            }
            else
            {
                ScoreBoard.Score -= 200;
                GameObject.Find("BuySkorpion_VZ").GetComponent<Button>().transform.Find("Text").GetComponent<Text>().text = "Sold Out!";
                hasBeenBuy = true;
            }
        }
        else
        {
            GameObject.Find("BuySkorpion_VZ").GetComponent<Button>().transform.Find("Text").GetComponent<Text>().text = "Sold Out!";
        }
    }
}
