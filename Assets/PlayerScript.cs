using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    public int health = 100;
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
}
