﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicLink : MonoBehaviour {

	bool isActive = false;
	public bool IsActive(){	return isActive;	}

	public Position itemPosition = new Position(0,0);

	public bool Activate(){
		isActive = true;
		return true; //TODO
	}
	public bool Desactivate(){
		isActive = false;
		return false; //TODO
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
