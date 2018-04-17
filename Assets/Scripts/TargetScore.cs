using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TargetScore : MonoBehaviour {

	public DisplayScore displayScore;
		

	void OnCollisionEnter (Collision other){
		if (other.gameObject.CompareTag ("Bullet")) {
			other.gameObject.SetActive (false);
			displayScore.SetCountText (1);
		}
	}
}

