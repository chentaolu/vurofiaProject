using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {
    public Player_health player_health;
    public int weaponAttackValue;
    public hitButton hitButton;
    public WeaponConfig nowWeapon;
    public List<WeaponConfig> weaponConfigs;

    // Use this for initialization
    void Start () {
        weaponAttackValue = FindUsingWeapon().getValue();
        print(weaponAttackValue);
    }
	
	// Update is called once per frame
	void Update () {
        weaponAttackValue = FindUsingWeapon().getValue();
        
        if (Player_health.currentHealth <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    public List<WeaponConfig> getCanUseList() {
        List<WeaponConfig> canUseWeaponList = new List<WeaponConfig>();
        foreach(WeaponConfig weapon in weaponConfigs)
        {
            if (weapon.getBoolCanUseOrNot())
            {
                //print(weapon.attackValue);
                canUseWeaponList.Add(weapon);
            }
        }
        return canUseWeaponList;
    }

    public void playerInToNextLevel()
    {
        Player_health.currentHealth += 30;
        if (Player_health.currentHealth > 100)
        {
            Player_health.currentHealth = 100;
        }
    }

    public WeaponConfig FindUsingWeapon()
    {
        WeaponConfig usingWeapon = null;
        foreach (WeaponConfig weapon in weaponConfigs)
        {
            if (weapon.usingNow)
            {
                usingWeapon = weapon;
            }
        }
        return usingWeapon;
    }

    public void changeWeapon(WeaponConfig wannaChange)
    {
        foreach(WeaponConfig weapon in weaponConfigs)
        {
            if(weapon.Equals(wannaChange))
            {
                weapon.usingNow = true;
                weapon.GoToRightLocation();
            }
            else
            {
                weapon.usingNow = false;
                weapon.GoOutOfRange();
            }
        }
    }
}
