using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNew1 : MonoBehaviour {

	public void Update (){
		if (GameObject.FindWithTag ("Target") == null ) {
			SceneManager.LoadScene ("GameScene2");
		}
	}
			}
