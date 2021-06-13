using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeButton : MonoBehaviour {

    public GameObject button;
    public static Sprite nowIcon;
    public static Sprite knife;
    public static Sprite shoot;

    public void Start()
    {
        knife = Resources.Load<Sprite>("weapon/knife_icon");
        shoot = Resources.Load<Sprite>("weapon/shoot_icon");
        nowIcon = knife;
        button = GameObject.Find("Button");
    }

    public void Update()
    {
        button.GetComponent<Image>().sprite = nowIcon;
    }

    public static void changeIcon(int num)
    {
        knife = Resources.Load<Sprite>("weapon/knife_icon");
        shoot = Resources.Load<Sprite>("weapon/shoot_icon");
        if (num != 0)
        {
            nowIcon = shoot;
        }
        else
        {
            nowIcon = knife;
        }
    }
}
