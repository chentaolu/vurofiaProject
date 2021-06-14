using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyCannon : MonoBehaviour
{
    public static bool hasBeenBuy = false;

    // Use this for initialization
    void Start()
    {
        if (hasBeenBuy)
        {
            GameObject.Find("BuyCannon").GetComponent<Button>().transform.Find("Text").GetComponent<Text>().text = "Sold Out!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        print(CannonConfig.isWeaponCanUse);
        CannonConfig.isWeaponCanUse = hasBeenBuy;
    }

    public void OnBtn()
    {
        if (!hasBeenBuy)
        {
            if (ScoreBoard.Score < 100000)
            {
                GameObject.Find("BuyCannon").GetComponent<Button>().transform.Find("Text").GetComponent<Text>().text = "";
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
