using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndOfLevel : MonoBehaviour {

	void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag ("Player"))
        {
			SceneManager.LoadScene("End Scene", LoadSceneMode.Single);
        }
    }
}