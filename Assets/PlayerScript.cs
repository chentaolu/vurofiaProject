using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {
    public Player_health player_health;
    public int weaponAttackValue;
    public Ak_47Config ak47_config;
    public M4A1Config m4a1_config;
    public UMP45Config ump45config;
    public SkorpionVZConfig skorpionVZConfig;
    public KnifeConfig KnifeConfig;
    public hitButton hitButton;
    public WeaponConfig nowWeapon;
    public List<WeaponConfig> weaponConfigs;

    // Use this for initialization
    void Start () {
        weaponConfigs.Add(ak47_config);
        weaponConfigs.Add(m4a1_config);
        weaponConfigs.Add(ump45config);
        weaponConfigs.Add(skorpionVZConfig);
        weaponConfigs.Add(KnifeConfig);
    }
	
	// Update is called once per frame
	void Update () {
        weaponAttackValue = FindUsingWeapon().attackValue;
        if(Player_health.currentHealth <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    public List<WeaponConfig> getCanUseList() {
        List<WeaponConfig> canUseWeaponList = new List<WeaponConfig>();
        foreach(WeaponConfig weapon in weaponConfigs)
        {
            if (weapon.isWeaponCanUse)
            {
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
        return weaponConfigs.Find(x => x.usingNow);
    }

    public void changeWeapon(WeaponConfig wannaChange)
    {
        foreach(WeaponConfig weapon in weaponConfigs)
        {
            if(weapon.Equals(wannaChange))
            {
                weapon.usingNow = true;
            }
            else
            {
                weapon.usingNow = false;
            }
        }
    }
}
