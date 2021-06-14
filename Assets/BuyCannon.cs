using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyCannon : MonoBehaviour {
    public static bool hasBeenBuy;

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
            if (ScoreBoard.Score < 100000)
            {
                GameObject.Find("BuyCannon").GetComponent<Button>().transform.Find("Text").GetComponent<Text>().text = "你騙不到老闆";
            }
            else
            {
                ScoreBoard.Score -= 100000;
                GameObject.Find("BuyCannon").GetComponent<Button>().transform.Find("Text").GetComponent<Text>().text = "Sold Out!";
                hasBeenBuy = true;
            }
        }
        else
        {
            GameObject.Find("BuyCannon").GetComponent<Button>().transform.Find("Text").GetComponent<Text>().text = "Sold Out!";
        }
    }
}
