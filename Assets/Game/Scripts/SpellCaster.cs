using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCaster : MonoBehaviour {


	void castFireSpell(){
		GameObject currentSpell = Spells.getInstance ().fireSpells.Pop ();
		//Spells.getInstance ().incrementFireSpellCount ();
		currentSpell.transform.position = this.transform.position;
		float vel= currentSpell.GetComponent<Spell> ().velocity;
		currentSpell.GetComponent<Spell> ().startLiveTimer ();
		currentSpell.GetComponent<Rigidbody> ().velocity=transform.TransformDirection(Vector3.forward*vel);

		//Spells.getInstance ().spells [0].GetComponent<Rigidbody> ().AddForce (transform.forward*100);
	}

	void Update(){
		//if(Input.touchCount==1){
		if(Input.GetMouseButtonDown(0)){
			castFireSpell();
		}
	}
}
