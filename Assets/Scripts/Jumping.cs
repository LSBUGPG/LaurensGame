using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour {

	public int forceConst = 50;
	private bool canJump;
	private Rigidbody selfRigidBody;
	public Rigidbody rb;
	public float disToGround;

	void Start (){
		selfRigidBody = GetComponent <Rigidbody> ();
		//get distance to ground

	}

	bool IsGrounded () {
		return Physics.Raycast (transform.position, -Vector3.up, disToGround + 0.1f);
	}

	void FixedUpdate (){
		if (canJump) {
			canJump = false;
			rb.AddForce (new Vector3 (0, 6, 0), ForceMode.Impulse);
			//selfRigidBody.AddForce (0, forceConst, 0, ForceMode.Impulse);
		}
	}

	void Update (){
		if (Input.GetKeyUp (KeyCode.Space) && IsGrounded()){
			canJump = true;
		}
	}
}


