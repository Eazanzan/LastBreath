using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIObjects : MonoBehaviour {
	public GameObject mainMenu;
	public GameObject optionsMenu;
	public GameObject playMenu;
	// Use this for initialization
	public void toMainMenu(){
		mainMenu.SetActive (true);
		optionsMenu.SetActive (false);
		playMenu.SetActive (false);
	}
	public void toPlayMenu(){
		mainMenu.SetActive (false);
		optionsMenu.SetActive (false);
		playMenu.SetActive (true);
	}
	public void toOptionsMenu(){
		mainMenu.SetActive (false);
		optionsMenu.SetActive (true);
		playMenu.SetActive (false);
	}
}
