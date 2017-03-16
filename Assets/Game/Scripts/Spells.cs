using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spells {
	//Stacks for loading instantiated objects
	public Stack<GameObject> fireSpells = new Stack<GameObject> ();
	public Stack<GameObject> lightningSpells = new Stack<GameObject> ();
	public Stack<GameObject> earthSpells =new Stack<GameObject> ();
	public Stack<GameObject> waterSpells = new Stack<GameObject> ();
	public Stack<GameObject> windSpells = new Stack<GameObject> ();
	//Object instance
	private static Spells instance;

	static Spells(){}

	public static Spells getInstance(){
		if (instance == null) {
			instance = new Spells ();
		}
		return instance;
	}
}
