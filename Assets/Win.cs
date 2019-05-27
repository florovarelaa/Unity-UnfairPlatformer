using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour {

public GameObject textWin;

	void OnTriggerEnter2D(Collider2D other){
		if(other.CompareTag("Player")){
			GameController.Instance.Win();
		}
	}
}
