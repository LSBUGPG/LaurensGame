using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageFalling : MonoBehaviour {

	public Rigidbody character;
	public PlayerHealth health;
	public Slider healthSlider;

	void OnCollisionEnter(Collision other){
		Debug.Log (character.velocity.y);
		if (character.velocity.y > 7) {
			health.TakeDamage (10);
		}

	}
}


