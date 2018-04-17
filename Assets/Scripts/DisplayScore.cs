using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour {
	 
	public Text targetText;
	public int TargetDestroyed = 0;

	public void SetCountText(int score){
		TargetDestroyed += score;
		targetText.text = "Targets Destroyed: " + TargetDestroyed.ToString ();
	}
}
	
	