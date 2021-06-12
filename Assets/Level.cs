using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {
    public int nowLevel = 1;
    public void nextLevel ()
    {
        this.nowLevel = this.nowLevel + 1;
    }
}
