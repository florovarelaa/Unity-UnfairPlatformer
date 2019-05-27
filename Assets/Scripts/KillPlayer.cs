using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

	[SerializeField]
	private bool collision;

	[SerializeField]
	private bool trigger;

	//Kill the player
		void OnCollisionEnter2D(Collision2D other){
			if(other.gameObject.tag == "Player"){
				if(collision){
					Action();
				}
			}
		}

		void OnTriggerEnter2D(Collider2D other){
			if(other.tag == "Player"){
				if(trigger){
					Action();
				}
			}
		}
	
	void Action() {
		gameObject.GetComponent<Renderer>().material.color = new Color(100, 100, 100, 1);
		PlayerController.Instance.Die();
	}
}
