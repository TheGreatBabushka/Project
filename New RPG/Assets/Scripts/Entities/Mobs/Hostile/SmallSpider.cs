﻿using UnityEngine;
using System.Collections;

public class SmallSpider : HostileMob {

	// Use this for initialization
	void Start () {
		attackLevel = 3;
		defenseLvl = 1;
		strengthLvl = 1;
		agilityLvl = 2;
		secondsToRegain1HP = 10;
		maxHealth = curHealth = 6;
		attackTimer = timeToReAttack = 2.0f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	protected override void die ()
	{
		GameObject.Destroy (this);
	}
}