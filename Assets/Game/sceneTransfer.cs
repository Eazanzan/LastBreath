using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneTransfer : MonoBehaviour {

	public void changeScene(){
		SceneManager.LoadScene (2);
	}
}
