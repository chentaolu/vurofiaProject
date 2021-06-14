using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicineCabinetScript : MonoBehaviour
{
    public static int amount = 2;
    public PlayerScript player;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnBtn()
    {
        if (amount > 0)
        {
            amount = amount - 1;
            Player_health.currentHealth = 100;
        }
    }
}
