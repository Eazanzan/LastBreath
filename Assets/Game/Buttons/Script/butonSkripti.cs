using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class butonSkripti : MonoBehaviour,IPointerClickHandler {


	public bool MM;
	public bool PM;
	public bool OM;

	public void OnPointerClick(PointerEventData e){
		

		if (PM) {
			UIController.getInstance ().toPM ();
		} else if (OM) {
			UIController.getInstance ().toOM();	
		} else if (MM) {
			UIController.getInstance ().toMM ();
		}

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
