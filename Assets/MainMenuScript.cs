using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour {
	public GameObject mainMenu;
	public GameObject playMenu;
	public GameObject optionsMenu;

	public void mainMenutoPlay(){
		mainMenu.SetActive (false);
		playMenu.SetActive (true);
	}

	public void backToMainMenuPlay(){
		mainMenu.SetActive (true);
		playMenu.SetActive (false);
	}

	public void mainMenuToOptions(){
		mainMenu.SetActive (false);
		optionsMenu.SetActive (true);
	}
	public void optionsToMainMenu(){
		mainMenu.SetActive (true);
		optionsMenu.SetActive (false);
	}

	public void fonksiyon(bool mainMenuActiveness,bool optionsMenuActiveness){
		mainMenu.SetActive (mainMenuActiveness);
		optionsMenu.SetActive (optionsMenuActiveness);

	}
}
