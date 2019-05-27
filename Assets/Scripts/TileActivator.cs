using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileActivator : MonoBehaviour {

	public GameObject BoxText;

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			BoxText.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -15);
		}
	}
}
