﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MapElement {

	override public bool isFree(){return true;}
	override public bool isPushable(){return false;}

	public LogicLink link;

	override public bool ProcessTurn (){
		return true;
	}

	public override void SteppedOn(MapElement by){
		if (typeof(Character).IsAssignableFrom(by.GetType ())) {
			GameHandler.instance.NextLevel ();
		}
	}
}
