using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	int health= 50;


	public void damage(int dmg){
		
		health -= dmg;
		if (health < 0) {
			Destroy (this.gameObject);
		}
		Debug.Log ("Ouch!");
	}
}
