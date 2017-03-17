using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour {
	public int damage;
	public string element;
	public float liveTime;
	public float velocity;
	public Vector3 initPos;
	bool live=false;
	float currTime;



	void Update(){
		if (live) {
			currTime -= Time.deltaTime;
			if (currTime < 0) {
				dispell ();
			}
		}
	}

	public void dispell(){
		live = false;
		this.GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 0);
		this.transform.position = initPos;
		if(element.CompareTo("fire")==0)
			Spells.getInstance ().fireSpells.Push (this.gameObject);
		if (element.CompareTo ("water")==0)
			Spells.getInstance ().waterSpells.Push (this.gameObject);
		if(element.CompareTo("earth")==0)
			Spells.getInstance ().earthSpells.Push (this.gameObject);
		if (element.CompareTo ("wind")==0)
			Spells.getInstance ().windSpells.Push (this.gameObject);
		if(element.CompareTo("lightning")==0)
			Spells.getInstance ().lightningSpells.Push (this.gameObject);
	}

	public void setPos(Vector3 pos){
		initPos = pos;
	}

	public void startLiveTimer(){
		currTime = liveTime;
		live = true;
	}

	void OnCollisionEnter(Collision col){
		Debug.Log (col.collider.gameObject.name);
		if (col.gameObject.tag == "Enemy") {
			
			col.gameObject.GetComponent<Enemy> ().damage (damage);
		}
		dispell ();
	}
}
