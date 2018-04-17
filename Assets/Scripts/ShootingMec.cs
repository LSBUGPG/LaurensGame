using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingMec : MonoBehaviour {

	public GameObject bulletMove;
	public Transform bulletSpawn;


	void Update (){
		if (Input.GetMouseButtonUp(0)) {
			Fire ();
		}
	}


	void Fire (){
		var bullet = (GameObject) Instantiate(
			bulletMove,
			bulletSpawn.position,
			bulletSpawn.rotation);

		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 30;
	}
}
