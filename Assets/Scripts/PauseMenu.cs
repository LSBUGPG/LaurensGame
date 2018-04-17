using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour {

	GameObject[] pauseObjects;

	//base tutorial found from www.sitepoint.com

	void Awake () {
		Time.timeScale = 0;
		pauseObjects = GameObject.FindGameObjectsWithTag ("ShowOnPause");
	}

	void Start() {
		hidePaused ();
	}
	 
		//removed input


	public void LoadScene (){
		SceneManager.LoadScene(("MainMenu"), LoadSceneMode.Single);
	}


	public void pauseControl(){
		if(Time.timeScale == 0)
		{
			Time.timeScale = 0;
			showPaused();
		} else if (Time.timeScale == 0){
			Time.timeScale = 1;
			hidePaused();
		}
	}

	public void showPaused(){
		foreach(GameObject g in pauseObjects){
			Debug.Log ("show", g);
			g.SetActive(true);
		}
	}
		
	public void hidePaused(){
		foreach(GameObject g in pauseObjects){
			Debug.Log ("hide", g);
			g.SetActive(false);
		}
	}
		
	//changed scene loader
	public void Reload (string level){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
	}



}
