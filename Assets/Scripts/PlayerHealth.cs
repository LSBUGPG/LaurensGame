using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour {

	public GameObject character;
	public Image HBImage;
	public Image HBText;
	public int maxHealth;
	public int health = 100;
	public int currentHealth;


	public void TakeDamage(int damage){
		health -= damage;
	}
}

