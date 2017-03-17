using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Instantiator : MonoBehaviour {
	public GameObject fireSpellPrefab;
	public GameObject lightningSpellPrefab;
	public GameObject earthSpellPrefab;
	public GameObject waterSpellPrefab;
	public GameObject windSpellPrefab;
	float a = 0;

	// Use this for initialization
	void Awake () {
		loadFireSpells ();
		loadLightningSpells ();
		loadEarthSpells ();
		loadWaterSpells ();
		loadWindSpells ();
		
	}

	void loadFireSpells(){
		for (int i = 0; i < 20; i++) {
			GameObject obyekt= Instantiate (fireSpellPrefab, this.transform.position+(new Vector3(a,0,0)), this.transform.rotation);
			obyekt.GetComponent<Spell> ().setPos (obyekt.transform.position+(new Vector3(a,0,0)));
			Spells.getInstance ().fireSpells.Push (obyekt);
			a+=0.15f;
		}
		a = 0;
	}
	void loadLightningSpells(){
		for (int i = 0; i < 20; i++) {
			GameObject obyekt= Instantiate (lightningSpellPrefab, this.transform.position+(new Vector3(a,1,0)), this.transform.rotation);
			obyekt.GetComponent<Spell> ().setPos (obyekt.transform.position+(new Vector3(a,0,0)));
			Spells.getInstance ().lightningSpells.Push (obyekt);
			a+=0.15f;
		}
		a = 0;
	}

	void loadEarthSpells(){
		for (int i = 0; i < 20; i++) {
			GameObject obyekt= Instantiate (earthSpellPrefab, this.transform.position+(new Vector3(a,2,0)), this.transform.rotation);
			obyekt.GetComponent<Spell> ().setPos (obyekt.transform.position+(new Vector3(a,0,0)));
			Spells.getInstance ().earthSpells.Push (obyekt);
			a+=0.15f;
		}
		a = 0;
	}

	void loadWindSpells(){
		for (int i = 0; i < 20; i++) {
			GameObject obyekt= Instantiate (windSpellPrefab, this.transform.position+(new Vector3(a,3,0)), this.transform.rotation);
			obyekt.GetComponent<Spell> ().setPos (obyekt.transform.position+(new Vector3(a,0,0)));
			Spells.getInstance ().windSpells.Push (obyekt);
			a+=0.15f;
		}
		a = 0;
	}

	void loadWaterSpells(){
		for (int i = 0; i < 20; i++) {
			GameObject obyekt= Instantiate (waterSpellPrefab, this.transform.position+(new Vector3(a,4,0)), this.transform.rotation);
			obyekt.GetComponent<Spell> ().setPos (obyekt.transform.position+(new Vector3(a,0,0)));
			Spells.getInstance ().waterSpells.Push (obyekt);
			a+=0.15f;
		}
		a = 0;
	}

}
