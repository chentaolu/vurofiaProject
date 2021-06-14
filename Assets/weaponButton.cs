using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weaponButton : MonoBehaviour
{
	public GameObject button;
	public Sprite targetImage;
	public List<Sprite> spritesList;
	public int index = 0;
	public PlayerScript playerScript;
	public KnifeConfig knifeConfig;
	public Ak_47Config ak_47Config;
	public M4A1Config m4A1Config;
	public SkorpionVZConfig skorpionVZConfig;
	public UMP45Config uMP45Config;

	Sprite Knife;
	Sprite UMP_45;
	Sprite Skorpion_VZ;
	Sprite M4A1;
	Sprite Ak_47;

	// Use this for initialization
	void Start()
	{
		Knife = Resources.Load<Sprite>("weapon/Knife");
		UMP_45 = Resources.Load<Sprite>("weapon/UMP-45");
		Skorpion_VZ = Resources.Load<Sprite>("weapon/Skorpion_VZ");
		M4A1 = Resources.Load<Sprite>("weapon/M4A1");
		Ak_47 = Resources.Load<Sprite>("weapon/Ak-47");
		initSpritesList();
		targetImage = spritesList[0];
		button = GameObject.Find("WeaponButton");
	}

	// Update is called once per frame
	void Update()
	{
		updateSpritesList();
		button.GetComponent<Image>().sprite = targetImage;
	}

	void initSpritesList()
	{
		spritesList.Clear();
		spritesList.Add(Knife);
		//spritesList.Add(Ak_47);
	}

	void updateSpritesList()
    {
		List<WeaponConfig> canUseList = playerScript.getCanUseList();
		if (canUseList.Count == 1)
        {
			print("only knife");
		}
        else if (canUseList.Count > 1)
        {
			print("buying success");
        }
		if (canUseList.Count != 0)
        {
			for(int i = 0; i < canUseList.Count; i++)
			{
				if (canUseList[i].GetType().Equals(typeof(M4A1Config)))
                {
					spritesList.Add(M4A1);
                }
				else if (canUseList[i].GetType().Equals(typeof(Ak_47Config)))
                {
					spritesList.Add(Ak_47);
                }
				else if (canUseList[i].GetType().Equals(typeof(UMP45Config)))
                {
					spritesList.Add(UMP_45);
                }
				else if (canUseList[i].GetType().Equals(typeof(SkorpionVZConfig)))
                {
					spritesList.Add(Skorpion_VZ);
                }
			}
        }
    }

	public void changeItems()
	{
		index++;
		if (index > spritesList.Count - 1)
        {
			index = 0;
        }

		targetImage = spritesList[index];

		if (index == 0)
        {
			changeButton.changeIcon(0);
        } else {
			changeButton.changeIcon(1);
        }

		if (spritesList[index] == Knife)
		{
			playerScript.changeWeapon(knifeConfig);
		}
		else if (spritesList[index] == Ak_47)
		{
			playerScript.changeWeapon(ak_47Config);
		}
		else if (spritesList[index] == UMP_45)
		{
			playerScript.changeWeapon(uMP45Config);
		}
		else if (spritesList[index] == M4A1)
        {
			playerScript.changeWeapon(m4A1Config);
        }
		else if (spritesList[index] == Skorpion_VZ)
        {
			playerScript.changeWeapon(skorpionVZConfig);
        }
	}
}
