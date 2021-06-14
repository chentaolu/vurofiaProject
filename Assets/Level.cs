using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {
    public static int nowLevel = 1;
    public static void nextLevel ()
    {
        nowLevel = nowLevel + 1;
    }
}
