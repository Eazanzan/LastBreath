using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCaster : MonoBehaviour {

	int currentSpellIndex=1;

	void propelSpell(GameObject currentSpell){
		currentSpell.transform.position = this.transform.position;
		float vel= currentSpell.GetComponent<Spell> ().velocity;
		currentSpell.GetComponent<Spell> ().startLiveTimer ();
		currentSpell.GetComponent<Rigidbody> ().velocity=transform.TransformDirection(Vector3.forward*vel);
	}

	void castFireSpell(){
		GameObject currentSpell = Spells.getInstance ().fireSpells.Pop ();
		propelSpell (currentSpell);
		/*currentSpell.transform.position = this.transform.position;
		float vel= currentSpell.GetComponent<Spell> ().velocity;
		currentSpell.GetComponent<Spell> ().startLiveTimer ();
		currentSpell.GetComponent<Rigidbody> ().velocity=transform.TransformDirection(Vector3.forward*vel);*/
	}

	void castLightningSpell(){
		GameObject currentSpell = Spells.getInstance ().lightningSpells.Pop ();
		propelSpell (currentSpell);
	}

	void castWindSpell(){
		GameObject currentSpell = Spells.getInstance ().windSpells.Pop ();
		propelSpell (currentSpell);
	}

	void castEarthSpell(){
		GameObject currentSpell = Spells.getInstance ().earthSpells.Pop ();
		propelSpell (currentSpell);
	}

	void castWaterSpell(){
		GameObject currentSpell = Spells.getInstance ().waterSpells.Pop ();
		propelSpell (currentSpell);
	}

	void Update(){
		//if(Input.touchCount==1){
		if(Input.GetKey(KeyCode.Alpha1))currentSpellIndex=1;
		if (Input.GetKey (KeyCode.Alpha2))
			currentSpellIndex = 2;
		if (Input.GetKey (KeyCode.Alpha3))
			currentSpellIndex = 3;
		if (Input.GetKey (KeyCode.Alpha4))
			currentSpellIndex = 4;
		if (Input.GetKey (KeyCode.Alpha5))
			currentSpellIndex = 5;
		if(Input.GetMouseButtonDown(0)){
			castSpell ();
		}
	}

	void castSpell(){
		switch (currentSpellIndex) {
		case 1:
			castFireSpell ();
			break;
		case 2:
			castLightningSpell ();
			break;
		case 3:
			castWindSpell ();
			break;
		case 4:
			castEarthSpell ();
			break;
		case 5:
			castWaterSpell ();
			break;
		}
	}
}
