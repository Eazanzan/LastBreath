using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController{
	private static UIController instance;
	private static GameObject uiObjects=null;
	static UIController(){
		uiObjects = GameObject.Find ("UIObjects");
	}
	public static UIController getInstance(){
		if (instance == null) {
			instance = new UIController ();
		}
		return instance;
	}
		
	public void toOM(){
		uiObjects.SendMessage ("toOptionsMenu");
	}

	public void toPM(){
		uiObjects.SendMessage ("toPlayMenu");
	}

	public void toMM(){
		uiObjects.SendMessage ("toMainMenu");
	}

	// Update is called once per frame
	void Update () {
		
	}
}
