using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;


public class ScoreBoard : MonoBehaviour
{

    //宣告分數參數
    public static int Score;

    //宣告文字UI
    public Text ShowScore;

    public static void addScore(int reward)
    {
        Score = Score + reward;
    }

    public static void init()
    {
        Score = 0;
    }

    private void Start()
    {
        Score = 100;
    }

    void Update()
    {
        //同步UI文字與分數
        ShowScore.text = Score.ToString();
    }

}
