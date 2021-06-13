using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weaponButton : MonoBehaviour
{
	public Level level;
	public GameObject button;
	public Sprite targetImage;
	public List<Sprite> spritesList;
	public int index = 0;

	// Use this for initialization
	void Start()
	{
		initSpritesList();
		targetImage = spritesList[0];
		button = GameObject.Find("WeaponButton");
	}

	// Update is called once per frame
	void Update()
	{
		button.GetComponent<Image>().sprite = targetImage;
	}

	void initSpritesList()
	{
		Sprite weapon0 = Resources.Load<Sprite>("weapon/Knife");
		Sprite weapon1 = Resources.Load<Sprite>("weapon/UMP-45");
		Sprite weapon2 = Resources.Load<Sprite>("weapon/Skorpion_VZ");
		Sprite weapon3 = Resources.Load<Sprite>("weapon/M4A1");
		Sprite weapon4 = Resources.Load<Sprite>("weapon/Ak-47");
		Sprite weapon5 = Resources.Load<Sprite>("weapon/Smoke_Grenade");
		Sprite weapon6 = Resources.Load<Sprite>("weapon/ACOG_Sight");
		spritesList.Add(weapon0);
		spritesList.Add(weapon1);
		spritesList.Add(weapon2);
		spritesList.Add(weapon3);
		spritesList.Add(weapon4);
		spritesList.Add(weapon5);
		spritesList.Add(weapon6);
	}

	public void changeItems()
	{
		index++;
		if (index > level.nowLevel)
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
	}
}
