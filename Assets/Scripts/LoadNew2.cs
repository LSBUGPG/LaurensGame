using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNew2 : MonoBehaviour {

	public void Update (){
		if (GameObject.FindWithTag ("Target") == null ) {
			SceneManager.LoadScene ("GameScene3");
		}
	}
			}
